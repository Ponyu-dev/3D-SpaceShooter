// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-06
// <file>: DespawnBehaviour.cs
// ------------------------------------------------------------------------------

using Atomic.Entities;
using NTC.Pool;
using UnityEngine;

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
            Debug.Log($"[DespawnBehaviour] OnDespawn {entity.Name}");
            NightPool.Despawn(entity.GetTransform().Value.gameObject);
        }

        public void Disable(IEntity entity)
        {
            entity.GetDespawnEvent().Unsubscribe(OnDespawn);
        }
    }
}