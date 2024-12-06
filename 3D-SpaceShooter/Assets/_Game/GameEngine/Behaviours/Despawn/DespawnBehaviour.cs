// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-06
// <file>: DespawnBehaviour.cs
// ------------------------------------------------------------------------------

using Atomic.Entities;
using NTC.Pool;

namespace _Game.GameEngine.Behaviours.Despawn
{
    public sealed class DespawnBehaviour : IEntityEnable, IEntityDisable
    {
        public void Enable(IEntity entity)
        {
            entity.GetDespawnEvent().Subscribe(OnDespawn);
        }

        private void OnDespawn(IEntity entity)
        {
            if (entity.TryGetTransform(out var transform) &&
                transform.Value is not null)
                NightPool.Despawn(transform.Value.gameObject);
        }

        public void Disable(IEntity entity)
        {
            entity.GetDespawnEvent().Unsubscribe(OnDespawn);
        }
    }
}