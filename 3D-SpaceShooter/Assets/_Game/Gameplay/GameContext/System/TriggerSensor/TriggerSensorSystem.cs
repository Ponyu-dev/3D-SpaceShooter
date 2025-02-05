// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-05
// <file>: TriggerSensorSystem.cs
// ------------------------------------------------------------------------------

using Atomic.Contexts;
using Atomic.Entities;
using UnityEngine;

namespace _Game.Gameplay.GameContext.System.TriggerSensor
{
    public sealed class TriggerSensorSystem : IContextInit, IContextEnable, IContextDisable
    {
        private Elementary.TriggerSensor _triggerSensor;
        private IContext _context;
        
        public void Init(IContext context)
        {
            _context = context;
            _triggerSensor = context.GetTriggerSensor().Value;
        }

        public void Enable(IContext context)
        {
            _triggerSensor.OnTriggerEntered += OnTriggerEntered;
            _triggerSensor.OnTriggerStaying += OnTriggerStaying;
            _triggerSensor.OnTriggerExited += OnTriggerExited;
        }

        private void OnTriggerEntered(Collider collider)
        {
            if (!_context.GetCanGamePlay().Value)
                return;
            
            if (collider.TryGetComponent<SceneEntity>(out var entity) &&
                entity.TryGetDespawnEvent(out var despawnEvent))
            {
                despawnEvent.Invoke(entity);
            }
        }

        private void OnTriggerStaying(Collider collider)
        {
            
        }

        private void OnTriggerExited(Collider collider)
        {
            
        }

        public void Disable(IContext context)
        {
            _triggerSensor.OnTriggerEntered -= OnTriggerEntered;
            _triggerSensor.OnTriggerStaying -= OnTriggerStaying;
            _triggerSensor.OnTriggerExited -= OnTriggerExited;
        }
    }
}