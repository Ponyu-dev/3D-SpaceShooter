// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-04
// <file>: AsteroidsSpawnerSystem.cs
// ------------------------------------------------------------------------------

using _Game.Gameplay.Asteroids.Scripts.Data;
using _Game.Gameplay.Asteroids.Scripts.UseCases;
using Atomic.Contexts;
using Atomic.Elements;
using Atomic.Entities;

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

        private int _countTest = 0;

        private void Spawn()
        {
            if (_countTest > 2)
                return;
            
            var go = _gameContext.SpawnAsteroidInArea();
            var index = _asteroidsProperties.Value.SpawnAsteroid(go.transform, -_gameContext.GetPlayerBounds().Value.RandomAsteroidSpawnPoint());
            
            _countTest++;
            
            if (go.TryGetComponent<SceneEntity>(out var entity))
            {
                entity.GetTriggerEnteredEvent().Subscribe(OnTriggerEntered);
                
                if (entity.HasAsteroidIndex())
                    entity.DelAsteroidIndex();

                entity.AddAsteroidIndex(new Const<int>(index));
            }
        }

        private void OnTriggerEntered(IEntity entity)
        {
            entity.GetTriggerEnteredEvent().Unsubscribe(OnTriggerEntered);
            _asteroidsProperties.Value.DespawnAsteroid(entity.GetAsteroidIndex().Value);
            _countTest--;
        }
    }
}