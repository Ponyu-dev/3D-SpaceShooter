// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-06
// <file>: BulletEntityInstaller.cs
// ------------------------------------------------------------------------------

using _Game.GameEngine.Behaviours.Despawn;
using _Game.GameEngine.Behaviours.Move.Movement;
using _Game.GameEngine.Behaviours.Physics;
using _Game.GameEngine.Behaviours.Visual;
using Atomic.Elements;
using Atomic.Entities;
using NTC.Pool;
using UnityEngine;

namespace _Game.Gameplay.Bullets.Scripts
{
    public sealed class BulletEntityInstaller : SceneEntityInstallerBase, IDespawnable
    {
        [SerializeField] private DespawnBehaviourInstaller despawnBehaviourInstaller;
        [SerializeField] private TriggerSensorBehaviourInstaller triggerSensorBehaviourInstaller;
        
        private IEntity _entity;
        
        public override void Install(IEntity entity)
        {
            _entity = entity;
            _entity.AddBulletTag();
            despawnBehaviourInstaller.Install(_entity);
            triggerSensorBehaviourInstaller.Install(_entity);
        }

        public void InitTransformBehaviour()
        {
            _entity.AddPosition(new ReactiveVector3(transform.position));
            _entity.AddRotation(new ReactiveQuaternion(transform.rotation));
            _entity.AddTransform(transform);
            _entity.AddBehaviour<TransformBehaviour>();
        }

        public void InitMovementBehaviour(float defaultBulletSpeed, Vector3 defaultDirectionTarget)
        {
            _entity.AddMoveSpeed(new ReactiveFloat(defaultBulletSpeed));
            _entity.AddMoveDirection(new ReactiveVector3(defaultDirectionTarget));
            _entity.AddCanMove(new AndExpression(members: () => true));
            _entity.AddBehaviour<MovementBehaviour>();
        }

        public void InitDamage(int bulletDamage)
        {
            _entity.AddDamage(new ReactiveInt(bulletDamage));
        }
        
        public void OnDespawn()
        {
            _entity.ClearTags();

            _entity.DelBehaviour<TransformBehaviour>();
            _entity.DelBehaviour<MovementBehaviour>();
            
            _entity.DelDamage();
            _entity.DelPosition();
            _entity.DelRotation();
            _entity.DelTransform();
            _entity.DelMoveSpeed();
            _entity.DelMoveDirection();
        }
    }
}