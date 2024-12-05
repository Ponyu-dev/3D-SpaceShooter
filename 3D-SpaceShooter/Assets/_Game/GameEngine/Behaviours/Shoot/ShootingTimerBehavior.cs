// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-05
// <file>: ShootingTimerBehavior.cs
// ------------------------------------------------------------------------------

using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace _Game.GameEngine.Behaviours.Shoot
{
    public sealed class ShootingTimerBehavior : IEntityInit, IEntityEnable, IEntityDisable, IEntityUpdate
    {
        private Cycle _periodShoot;
        private AndExpression _canShoot;
        private BaseEvent _actionShoot;

        public void Init(IEntity entity)
        {
            _periodShoot = entity.GetPeriodShoot();
            _canShoot = entity.GetCanShoot();
            _actionShoot = entity.GetActionShoot();
        }

        public void Enable(IEntity entity)
        {
            Debug.Log("[ShootingTimerBehavior] Enable");
            _periodShoot.Start();
            _periodShoot.OnCycle += PeriodShoot;
        }

        private void PeriodShoot()
        {
            if (_canShoot.Value)
            {
                Debug.Log("[ShootingTimerBehavior] PeriodShoot");
                _actionShoot?.Invoke();
            }
            else
            {
                Debug.Log("[ShootingTimerBehavior] Can Not PeriodShoot");
            }
        }

        public void OnUpdate(IEntity entity, float deltaTime)
        {
            _periodShoot.Tick(deltaTime);
        }

        public void Disable(IEntity entity)
        {
            Debug.Log("[ShootingTimerBehavior] Disable");
            _periodShoot.Stop();
            _periodShoot.OnCycle -= PeriodShoot;
        }
    }
}