// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-05
// <file>: CollisionSensorBehaviour.cs
// ------------------------------------------------------------------------------

using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace _Game.GameEngine.Behaviours.Physics
{
    public sealed class CollisionSensorBehaviour : IEntityInit, IEntityEnable, IEntityDisable
    {
        private IEntity _entity;
        
        public void Init(IEntity entity)
        {
            _entity = entity;
        }

        public void Enable(IEntity entity)
        {
            entity.GetCollisionSensor().Value.OnCollisionEntered += OnCollisionEntered;
        }

        private void OnCollisionEntered(Collision collision)
        {
            if (!collision.gameObject.TryGetComponent<SceneEntity>(out var entity))
                return;
            
            if (entity.HasAsteroidTag() && _entity.HasAsteroidTag())
                return;
            
            if (entity.HasBulletTag() && _entity.HasBulletTag())
                return;

            if (!entity.TryGetTakeDamageEvent(out var damageEvent))
                return;
            
            if (_entity.TryGetDamage(out var damage))
                damageEvent.Invoke(damage.Value);
            
            _entity.GetDespawnEvent().Invoke(_entity);
            
            if (entity.HasBulletTag())
                entity.GetDespawnEvent().Invoke(entity);
        }

        public void Disable(IEntity entity)
        {
            entity.GetCollisionSensor().Value.OnCollisionEntered -= OnCollisionEntered;
        }
    }
}