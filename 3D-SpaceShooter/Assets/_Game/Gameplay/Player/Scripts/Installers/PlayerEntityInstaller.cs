// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-02
// <file>: PlayerEntityInstaller.cs
// ------------------------------------------------------------------------------

using System;
using _Game.GameEngine.Behaviours.HitPoints;
using _Game.GameEngine.Behaviours.Move.MovementBounded;
using _Game.GameEngine.Behaviours.Rotate.RotationTilt;
using _Game.GameEngine.Behaviours.Shoot;
using _Game.GameEngine.Behaviours.Visual;
using _Game.GameEngine.Behaviours.Weapons.ShootToForward;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace _Game.Gameplay.Player.Scripts.Installers
{
    [Serializable]
    public sealed class PlayerEntityInstaller : SceneEntityInstallerBase
    {
        [SerializeField] private MovementBoundedBehaviourInstaller movementBoundedBehaviourInstaller;
        [SerializeField] private RotationTiltBehaviourInstaller rotationTiltBehaviourInstaller;
        [SerializeField] private HitPointsBehaviourInstaller hitPointsBehaviourInstaller;
        [SerializeField] private ShootingTimerBehaviorInstaller shootingTimerBehaviorInstaller;
        [SerializeField] private WeaponShootToForwardBehaviorInstaller weaponShootToForwardBehaviorInstaller;
        
        public override void Install(IEntity entity)
        {
            entity.AddPlayerTag();
            entity.AddTransform(new Const<Transform>(transform));
            entity.AddPosition(new ReactiveVector3(transform.position));
            
            entity.AddBehaviour<TransformBehaviour>();
            
            hitPointsBehaviourInstaller.Install(entity);
            
            movementBoundedBehaviourInstaller.Install(entity);
            movementBoundedBehaviourInstaller.CanMoveAppend(hitPointsBehaviourInstaller.IsNotDead());
            
            rotationTiltBehaviourInstaller.Install(entity);
            rotationTiltBehaviourInstaller.CanRotateAppend(hitPointsBehaviourInstaller.IsNotDead());
            
            shootingTimerBehaviorInstaller.Install(entity);
            shootingTimerBehaviorInstaller.CanShootAppend(hitPointsBehaviourInstaller.IsNotDead());
            
            weaponShootToForwardBehaviorInstaller.Install(entity);
        }
    }
}