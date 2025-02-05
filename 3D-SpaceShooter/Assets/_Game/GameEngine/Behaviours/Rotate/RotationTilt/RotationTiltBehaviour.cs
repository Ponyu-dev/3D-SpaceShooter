// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-03
// <file>: RotationTiltBehaviour.cs
// ------------------------------------------------------------------------------

using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace _Game.GameEngine.Behaviours.Rotate.RotationTilt
{
    public sealed class RotationTiltBehaviour : IEntityInit, IEntityFixedUpdate
    {
        private ReactiveQuaternion _rotation;
        private ReactiveVector3 _moveDirection;
        private IValue<float> _tiltAmount;
        private IValue<float> _tiltSmoothness;
        private AndExpression _canRotate;
        
        public void Init(IEntity entity)
        {
            _rotation = entity.GetRotation();
            _moveDirection = entity.GetMoveDirection();
            _tiltAmount = entity.GetTiltAmount();
            _tiltSmoothness = entity.GetTiltSmoothness();
            _canRotate = entity.GetCanRotate();
        }

        public void OnFixedUpdate(IEntity entity, float deltaTime)
        {
            if (!_canRotate.Value)
                return;
            
            var targetTilt = Mathf.Clamp(-_moveDirection.Value.x * _tiltAmount.Value, -_tiltAmount.Value, _tiltAmount.Value);
            var tiltRotation = Quaternion.Euler(_rotation.Value.x, _rotation.Value.y, targetTilt);
            _rotation.Value = Quaternion.Slerp(_rotation.Value, tiltRotation, deltaTime * _tiltSmoothness.Value);
        }
    }
}