// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-03
// <file>: RotationTiltBehaviourInstaller.cs
// ------------------------------------------------------------------------------

using System;
using _Game.GameEngine.Behaviours.Common;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace _Game.GameEngine.Behaviours.Rotate.RotationTilt
{
    [Serializable]
    public sealed class RotationTiltBehaviourInstaller : IBehaviourInstaller
    {
        [SerializeField] private Const<float> tiltAmount = new(15f);
        [SerializeField] private Const<float> tiltSmoothness = new(5f);
        
        public void Install(IEntity entity)
        {
            entity.AddRotation(new ReactiveQuaternion());
            entity.AddTiltAmount(tiltAmount);
            entity.AddTiltSmoothness(tiltSmoothness);
            
            entity.AddBehaviour<RotationTiltBehaviour>();
        }
    }
}