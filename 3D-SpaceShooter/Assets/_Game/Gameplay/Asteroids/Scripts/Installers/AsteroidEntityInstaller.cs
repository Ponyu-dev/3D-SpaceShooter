// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-05
// <file>: AsteroidEntityInstaller.cs
// ------------------------------------------------------------------------------

using System;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace _Game.Gameplay.Asteroids.Scripts.Installers
{
    [Serializable]
    public sealed class AsteroidEntityInstaller : SceneEntityInstallerBase
    {
        [SerializeField] private BaseEvent<IEntity> triggerEnteredEvent;
        
        public override void Install(IEntity entity)
        {
            entity.AddTriggerEnteredEvent(triggerEnteredEvent);
        }
    }
}