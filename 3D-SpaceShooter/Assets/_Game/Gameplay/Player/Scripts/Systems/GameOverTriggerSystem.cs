// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-06
// <file>: GameOverTriggerSystem.cs
// ------------------------------------------------------------------------------

using Atomic.Contexts;
using Atomic.Elements;
using Atomic.Entities;

namespace _Game.Gameplay.Player.Scripts.Systems
{
    public sealed class GameOverTriggerSystem : IContextInit, IContextEnable, IContextDisable
    {
        private BaseEvent _gameOverEvent;
        private IReactiveValue<bool> _playerIsDead;
        private IReactiveVariable<bool> _isGamePlay;
        
        public void Init(IContext context)
        {
            _playerIsDead = context.GetPlayerEntity().Value.GetIsDead();
            _gameOverEvent = context.GetGameOverEvent();
            _isGamePlay = context.GetIsGamePlay();
        }

        public void Enable(IContext context)
        {
            _playerIsDead.Subscribe(PlayerIsDead);
        }

        private void PlayerIsDead(bool value)
        {
            if (!value)
                return;
            
            _gameOverEvent?.Invoke();
            _isGamePlay.Value = false;
        }

        public void Disable(IContext context)
        {
            _playerIsDead.Unsubscribe(PlayerIsDead);
        }
    }
}