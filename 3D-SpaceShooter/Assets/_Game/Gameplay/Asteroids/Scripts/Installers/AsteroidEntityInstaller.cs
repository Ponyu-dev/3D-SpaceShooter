// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-05
// <file>: AsteroidEntityInstaller.cs
// ------------------------------------------------------------------------------

using System;
using _Game.GameEngine.Behaviours.HitPoints;
using _Game.GameEngine.Behaviours.Physics;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace _Game.Gameplay.Asteroids.Scripts.Installers
{
    [Serializable]
    public sealed class AsteroidEntityInstaller : SceneEntityInstallerBase
    {
        [SerializeField] private BaseEvent<IEntity> despawnEvent;
        [SerializeField] private ReactiveInt damage;
        [SerializeField] private HitPointsBehaviourInstaller hitPointsBehaviourInstaller;
        [SerializeField] private TriggerSensorBehaviourInstaller triggerSensorBehaviourInstaller;
        
        public override void Install(IEntity entity)
        {
            entity.AddAsteroidTag();
            
            entity.AddDamage(damage);
            entity.AddDespawnEvent(despawnEvent);
            entity.AddPosition(new ReactiveVector3(Vector3.zero));
            hitPointsBehaviourInstaller.Install(entity);
            triggerSensorBehaviourInstaller.Install(entity);
            _entity = entity;
        }

        private IEntity _entity;
        private void OnDrawGizmos()
        {
            if (_entity is null || !_entity.HasPosition())
                return;
            Gizmos.color = Color.magenta;
            Gizmos.DrawSphere(_entity.GetPosition().Value, 1f);
            Gizmos.DrawLine(transform.position, _entity.GetPosition().Value);
        }
    }
}