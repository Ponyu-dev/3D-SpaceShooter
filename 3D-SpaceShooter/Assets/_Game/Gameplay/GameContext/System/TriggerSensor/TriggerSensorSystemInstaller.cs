// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-05
// <file>: TriggerSensorSystemInstaller.cs
// ------------------------------------------------------------------------------

using System;
using Atomic.Contexts;
using Atomic.Elements;
using UnityEngine;

namespace _Game.Gameplay.GameContext.System.TriggerSensor
{
    [Serializable]
    public sealed class TriggerSensorSystemInstaller : IContextInstaller
    {
        [SerializeField] private Elementary.TriggerSensor triggerSensor;
        
        public void Install(IContext context)
        {
            context.AddTriggerSensor(new Const<Elementary.TriggerSensor>(triggerSensor));
            context.AddSystem<TriggerSensorSystem>();
        }
    }
}