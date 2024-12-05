// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-05
// <file>: AsteroidEntityInstaller.cs
// ------------------------------------------------------------------------------

using System;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;
using UnityEngine.Rendering;

namespace _Game.Gameplay.Asteroids.Scripts.Installers
{
    [Serializable]
    public sealed class AsteroidEntityInstaller : SceneEntityInstallerBase
    {
        [SerializeField] private BaseEvent<IEntity> triggerEnteredEvent;
        
        public override void Install(IEntity entity)
        {
            entity.AddTriggerEnteredEvent(triggerEnteredEvent);
            entity.AddPosition(new ReactiveVector3(Vector3.zero));
            _entity = entity;
        }

        private IEntity _entity;
        private void OnDrawGizmos()
        {
            Gizmos.color = Color.magenta;
            Gizmos.DrawSphere(_entity.GetPosition().Value, 1f);
            
            Gizmos.DrawLine(transform.position, _entity.GetPosition().Value);
        }
    }
}