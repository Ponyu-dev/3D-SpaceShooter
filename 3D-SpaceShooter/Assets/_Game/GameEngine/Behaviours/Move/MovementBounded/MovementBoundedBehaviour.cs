// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-02
// <file>: MovementBoundedBehaviour.cs
// ------------------------------------------------------------------------------

using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace _Game.GameEngine.Behaviours.Move.MovementBounded
{
    public sealed class MovementBoundedBehaviour : IEntityInit, IEntityFixedUpdate
    {
        private IVariable<Vector3> _position;
        private IValue<Vector3> _moveDirection;
        private IValue<float> _moveSpeed;
        private AndExpression _canMove;

        private Const<Camera> _mainCamera;
        
        public void Init(IEntity entity)
        {
            _position = entity.GetPosition();
            _moveSpeed = entity.GetMoveSpeed();
            _moveDirection = entity.GetMoveDirection();
            _canMove = entity.GetCanMove();
            _mainCamera = entity.GetMainCamera();
        }

        public void OnFixedUpdate(IEntity entity, float deltaTime)
        {
            if (!_canMove.Value)
                return;
            
            MovementFunctions.MoveStep(
                _position.Value,
                _moveDirection.Value,
                _moveSpeed.Value,
                deltaTime,
                out var newPosition
            );
            
            var viewportPos = _mainCamera.Value.WorldToViewportPoint(newPosition);
            viewportPos.x = Mathf.Clamp(viewportPos.x, 0.1f, 0.9f);
            viewportPos.y = Mathf.Clamp(viewportPos.y, 0.1f, 0.9f);

            _position.Value = _mainCamera.Value.ViewportToWorldPoint(viewportPos);
        }
    }
}