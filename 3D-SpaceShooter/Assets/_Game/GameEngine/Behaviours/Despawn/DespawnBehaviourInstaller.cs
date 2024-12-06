// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-06
// <file>: DespawnBehaviourInstaller.cs
// ------------------------------------------------------------------------------

using System;
using _Game.GameEngine.Behaviours.Common;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace _Game.GameEngine.Behaviours.Despawn
{
    [Serializable]
    public sealed class DespawnBehaviourInstaller : IBehaviourInstaller
    {
        [SerializeField] private BaseEvent<IEntity> despawnEvent;
        
        public void Install(IEntity entity)
        {
            entity.AddDespawnEvent(despawnEvent);
            entity.AddBehaviour<DespawnBehaviour>();
        }
    }
}