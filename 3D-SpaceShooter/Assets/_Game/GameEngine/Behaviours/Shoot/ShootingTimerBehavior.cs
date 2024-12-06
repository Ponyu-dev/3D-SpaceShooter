// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-05
// <file>: ShootingTimerBehavior.cs
// ------------------------------------------------------------------------------

using Atomic.Elements;
using Atomic.Entities;

namespace _Game.GameEngine.Behaviours.Shoot
{
    public sealed class ShootingTimerBehavior : IEntityInit, IEntityEnable, IEntityDisable, IEntityUpdate
    {
        private Cycle _periodShoot;
        private AndExpression _canShoot;
        private BaseEvent _eventShoot;

        public void Init(IEntity entity)
        {
            _periodShoot = entity.GetPeriodShoot();
            _canShoot = entity.GetCanShoot();
            _eventShoot = entity.GetActionShoot();
        }

        public void Enable(IEntity entity)
        {
            _periodShoot.Start();
            _periodShoot.OnCycle += PeriodShoot;
        }

        private void PeriodShoot()
        {
            if (_canShoot.Value)
            {
                _eventShoot?.Invoke();
            }
        }

        public void OnUpdate(IEntity entity, float deltaTime)
        {
            _periodShoot.Tick(deltaTime);
        }

        public void Disable(IEntity entity)
        {
            _periodShoot.Stop();
            _periodShoot.OnCycle -= PeriodShoot;
        }
    }
}