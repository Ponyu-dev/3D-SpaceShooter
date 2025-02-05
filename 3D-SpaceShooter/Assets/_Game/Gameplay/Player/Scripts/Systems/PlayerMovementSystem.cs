// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-02
// <file>: PlayerMovementSystem.cs
// ------------------------------------------------------------------------------

using Atomic.Contexts;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace _Game.Gameplay.Player.Scripts.Systems
{
    public sealed class PlayerMovementSystem : IContextInit, IContextUpdate
    {
        private IReactiveValue<Vector3> _deltaMove;
        private IReactiveValue<bool> _isTouching;
        private IReactiveVariable<Vector3> _playerMoveDirection;
        
        public void Init(IContext context)
        {
            _deltaMove = context.GetDeltaMove();
            _isTouching = context.GetIsTouching();
            _playerMoveDirection = context.GetPlayerEntity().Value.GetMoveDirection();
            
            //TODO Move to a separate function
            context.GetPlayerEntity().Value.GetCanMove().Append(() => _isTouching.Value);
        }

        public void Update(IContext context, float deltaTime)
        {
            _playerMoveDirection.Value = _deltaMove.Value;
        }
    }
}