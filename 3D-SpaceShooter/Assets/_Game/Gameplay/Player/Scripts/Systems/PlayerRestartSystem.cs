// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-06
// <file>: PlayerRestartSystem.cs
// ------------------------------------------------------------------------------

using Atomic.Contexts;
using Atomic.Elements;
using Atomic.Entities;
using Elementary;
using UnityEngine;

namespace _Game.Gameplay.Player.Scripts.Systems
{
    public sealed class PlayerRestartSystem : IContextInit, IContextEnable, IContextDisable
    {
        private IReactiveVariable<bool> _playerIsDead;
        private IReactiveVariable<Vector3> _playerPosition;
        private IReactiveVariable<Quaternion> _playerRotation;
        private IReactiveVariable<Vector3> _playerMoveDirection;
        private IVariableLimited<int> _playerHitPoint;
        private BaseEvent _restartEvent;
        
        public void Init(IContext context)
        {
            _restartEvent = context.GetRestartEvent();
            
            var playerEntity = context.GetPlayerEntity().Value;
            _playerPosition = playerEntity.GetPosition();
            _playerRotation = playerEntity.GetRotation();
            _playerMoveDirection = playerEntity.GetMoveDirection();
            _playerIsDead = playerEntity.GetIsDead();
            _playerHitPoint = playerEntity.GetHitPoint();
        }

        public void Enable(IContext context)
        {
            _restartEvent.Subscribe(OnRestart);
        }

        private void OnRestart()
        {
            _playerPosition.Value = new Vector3(0f, 3f, 30f);
            _playerRotation.Value = Quaternion.identity;
            _playerMoveDirection.Value = Vector3.zero;
            _playerIsDead.Value = false;
            _playerHitPoint.Current = _playerHitPoint.MaxValue;
        }

        public void Disable(IContext context)
        {
            _restartEvent.Unsubscribe(OnRestart);
        }
    }
}