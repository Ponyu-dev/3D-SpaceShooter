// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-06
// <file>: TriggerSensorBehaviour.cs
// ------------------------------------------------------------------------------

using Atomic.Entities;
using Elementary;
using UnityEngine;

namespace _Game.GameEngine.Behaviours.Physics
{
    public sealed class TriggerSensorBehaviour : IEntityInit, IEntityEnable, IEntityDisable
    {
        private TriggerSensor _triggerSensor;
        private IEntity _entity;
       
        public void Init(IEntity entity)
        {
            _entity = entity;
            _triggerSensor = entity.GetTriggerSensor().Value;
        }

        public void Enable(IEntity entity)
        {
            _triggerSensor.OnTriggerEntered += OnTriggerEntered;
        }

        private void OnTriggerEntered(Collider collider)
        {
            if (!collider.gameObject.TryGetComponent<SceneEntity>(out var entity))
                return;
            
            if (_entity.HasAsteroidTag() && entity.HasPlayerTag())
            {
                OnTriggerAsteroid(entity);
            }
            else if (_entity.HasBulletTag() && entity.HasAsteroidTag())
            {
                OnTriggerBullet(entity);
            }
        }

        private void OnTriggerAsteroid(SceneEntity entityTrigger)
        {
            Debug.Log("OnTriggerAsteroid with Player");
            // Обработка столкновения с игроком.
            entityTrigger.GetTakeDamageEvent().Invoke(_entity.GetDamage().Value);
            // Уничтожить астероид.
            _entity.GetDespawnEvent().Invoke(_entity);
        }

        private void OnTriggerBullet(SceneEntity entityTrigger)
        {
            Debug.Log("OnTriggerBullet with Asteroid");
            // Нанести урон астероиду.
            entityTrigger.GetDespawnEvent().Invoke(entityTrigger);
            //entityTrigger.GetTakeDamageEvent().Invoke(_entity.GetDamage().Value);
            // Уничтожить пулю.
            _entity.GetDespawnEvent().Invoke(_entity);
        }

        public void Disable(IEntity entity)
        {
            _triggerSensor.OnTriggerEntered -= OnTriggerEntered;
        }
    }
}