// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-06
// <file>: GameOverSystem.cs
// ------------------------------------------------------------------------------

using _Game.Gameplay.GameContext;
using Atomic.Contexts;
using Atomic.Elements;
using Atomic.Entities;

namespace _Game.GameEngine.Behaviours.Common
{
    public sealed class GameOverSystem : IEntityEnable, IEntityDisable
    {
        private IEntity _entity;
        private BaseEvent<bool> _gameOverEvent;

        public void Enable(IEntity entity)
        {
            _entity = entity;
            _gameOverEvent ??= SingletonGameContext.Instance.GetGameOverEvent();
            _gameOverEvent.Subscribe(OnGameOver);
        }

        private void OnGameOver(bool isVictory)
        {
            if (_entity.TryGetDespawnEvent(out var despawnEvent))
            {
                despawnEvent.Invoke(_entity);
            }
        }

        public void Disable(IEntity entity)
        {
            _gameOverEvent.Unsubscribe(OnGameOver);
        }
    }
}