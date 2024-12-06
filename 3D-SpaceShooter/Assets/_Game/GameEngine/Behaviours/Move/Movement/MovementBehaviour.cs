// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-06
// <file>: MovementBehaviour.cs
// ------------------------------------------------------------------------------

using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace _Game.GameEngine.Behaviours.Move.Movement
{
    public sealed class MovementBehaviour : IEntityInit, IEntityFixedUpdate
    {
        private IVariable<Vector3> _position;
        private IValue<float> _moveSpeed;
        private IValue<Vector3> _moveDirection;
        private AndExpression _canMove;

        public void Init(IEntity entity)
        {
            _canMove = entity.GetCanMove();
            _position = entity.GetPosition();
            _moveSpeed = entity.GetMoveSpeed();
            _moveDirection = entity.GetMoveDirection();
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
            _position.Value = newPosition;
        }
    }
}