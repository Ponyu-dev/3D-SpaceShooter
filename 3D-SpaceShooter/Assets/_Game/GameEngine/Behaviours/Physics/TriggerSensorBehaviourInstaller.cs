// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-06
// <file>: TriggerSensorBehaviourInstaller.cs
// ------------------------------------------------------------------------------

using System;
using _Game.GameEngine.Behaviours.Common;
using Atomic.Elements;
using Atomic.Entities;
using Elementary;
using UnityEngine;

namespace _Game.GameEngine.Behaviours.Physics
{
    [Serializable]
    public sealed class TriggerSensorBehaviourInstaller : IBehaviourInstaller
    {
        [SerializeField] private Const<TriggerSensor> triggerSensor;
        
        public void Install(IEntity entity)
        {
            entity.AddTriggerSensor(triggerSensor);
            entity.AddBehaviour<TriggerSensorBehaviour>();
        }
    }
}