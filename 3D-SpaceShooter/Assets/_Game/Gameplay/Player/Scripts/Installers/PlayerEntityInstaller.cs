// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-02
// <file>: PlayerEntityInstaller.cs
// ------------------------------------------------------------------------------

using System;
using _Game.GameEngine.Behaviours.Move.MovementBoundedCameraSize;
using _Game.GameEngine.Behaviours.Rotate.RotationTilt;
using _Game.GameEngine.Behaviours.Visual;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace _Game.Gameplay.Player.Scripts.Installers
{
    [Serializable]
    public sealed class PlayerEntityInstaller : SceneEntityInstallerBase
    {
        [SerializeField] private MovementBoundedCameraSizeBehaviourInstaller movementBoundedCameraSizeBehaviourInstaller;
        [SerializeField] private RotationTiltBehaviourInstaller rotationTiltBehaviourInstaller;
        
        public override void Install(IEntity entity)
        {
            entity.AddPlayerTag();
            entity.AddTransform(new Const<Transform>(transform));
            entity.AddPosition(new ReactiveVector3(transform.position));
            
            entity.AddBehaviour<TransformBehaviour>();
            
            movementBoundedCameraSizeBehaviourInstaller.Install(entity);
            rotationTiltBehaviourInstaller.Install(entity);
            
            rotationTiltBehaviourInstaller.CanRotateAppend(movementBoundedCameraSizeBehaviourInstaller.IsCaneMove());
        }
    }
}