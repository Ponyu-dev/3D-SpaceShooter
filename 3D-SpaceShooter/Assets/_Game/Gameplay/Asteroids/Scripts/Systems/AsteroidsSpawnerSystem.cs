// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-04
// <file>: AsteroidsSpawnerSystem.cs
// ------------------------------------------------------------------------------

using _Game.Gameplay.Asteroids.Scripts.Data;
using _Game.Gameplay.Asteroids.Scripts.UseCases;
using Atomic.Contexts;
using Atomic.Elements;

namespace _Game.Gameplay.Asteroids.Scripts
{
    public sealed class AsteroidsSpawnerSystem : IContextInit, IContextEnable, IContextDisable, IContextUpdate
    {
        private IContext _gameContext;
        private Cycle _spawnPeriod;
        private IReactiveVariable<AsteroidsProperties> _asteroidsProperties;
        
        public void Init(IContext context)
        {
            _gameContext = context;
            _spawnPeriod = context.GetSpawnAsteroidData().Value.spawnCycle;
            _asteroidsProperties = context.GetReactiveAsteroidsProperties();
        }

        public void Enable(IContext context)
        {
            _spawnPeriod.Start();
            _spawnPeriod.OnCycle += this.Spawn;
        }

        public void Update(IContext context, float deltaTime)
        {
            _spawnPeriod.Tick(deltaTime);
        }

        public void Disable(IContext context)
        {
            _spawnPeriod.Stop();
            _spawnPeriod.OnCycle -= this.Spawn;
        }

        private void Spawn()
        {
            var go = _gameContext.SpawnAsteroidInArea();
            _asteroidsProperties.Value.SpawnAsteroid(go.transform, -_gameContext.GetPlayerBounds().Value.RandomAsteroidSpawnPoint());
        }
    }
}