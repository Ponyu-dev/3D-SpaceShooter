// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-05
// <file>: CollisionSensorBehaviourInstaller.cs
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
    public sealed class CollisionSensorBehaviourInstaller : IBehaviourInstaller
    {
        [SerializeField] private CollisionSensor collisionSensor;
        
        public void Install(IEntity entity)
        {
            entity.AddCollisionSensor(new Const<CollisionSensor>(collisionSensor));
            entity.AddBehaviour<CollisionSensorBehaviour>();
        }
    }
}