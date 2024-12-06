// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-06
// <file>: AsteroidsClearSystem.cs
// ------------------------------------------------------------------------------

using _Game.Gameplay.Asteroids.Scripts.Data;
using Atomic.Contexts;
using Atomic.Elements;

namespace _Game.Gameplay.Asteroids.Scripts
{
    public sealed class AsteroidsClearSystem : IContextInit, IContextEnable, IContextDisable
    {
        private BaseEvent _gameOverEvent;
        private IReactiveValue<AsteroidsProperties> _asteroidsProperties;
        
        public void Init(IContext context)
        {
            _gameOverEvent = context.GetGameOverEvent();
            _asteroidsProperties = context.GetReactiveAsteroidsProperties();
        }

        public void Enable(IContext context)
        {
            _gameOverEvent.Subscribe(OnGameOver);
        }

        private void OnGameOver()
        {
            
        }

        public void Disable(IContext context)
        {
            _gameOverEvent.Unsubscribe(OnGameOver);
        }
    }
}