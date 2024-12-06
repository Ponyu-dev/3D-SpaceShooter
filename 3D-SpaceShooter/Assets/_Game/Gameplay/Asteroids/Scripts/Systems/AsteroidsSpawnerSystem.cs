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
using UnityEngine;

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
            if (_countTest > 20)
                return;
            
            var go = _gameContext.SpawnAsteroidInArea();
            var targetPoint = _gameContext.GetPlayerBounds().Value.RandomAsteroidSpawnPoint();
            var positionDirection = (go.transform.position - targetPoint).normalized;
            _asteroidsProperties.Value.SpawnAsteroid(go.transform, positionDirection);
            
            _countTest++;
            
            if (go.TryGetComponent<SceneEntity>(out var entity))
            {
                entity.GetDespawnEvent().Subscribe(OnDespawnAsteroid);
                
                if (entity.HasTransform())
                    entity.DelTransform();
                entity.AddTransform(new Const<Transform>(go.transform));
                
                entity.GetPosition().Value = targetPoint;
            }
        }

        private void OnDespawnAsteroid(IEntity entity)
        {
            Debug.Log($"[AsteroidsSpawnerSystem] OnDespawnAsteroid {entity.Name}");
            entity.GetDespawnEvent().Unsubscribe(OnDespawnAsteroid);
            _asteroidsProperties.Value.DespawnAsteroid(entity.GetTransform().Value);
            _countTest--;
        }
    }
}