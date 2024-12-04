// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-04
// <file>: SpawnAsteroidUseCase.cs
// ------------------------------------------------------------------------------

using Atomic.Contexts;
using Atomic.Entities;
using NTC.Pool;
using UnityEngine;

namespace _Game.Gameplay.Asteroids.Scripts.UseCases
{
    public static class SpawnAsteroidUseCase
    {
        public static GameObject SpawnAsteroidInArea(this IContext gameContext)
        {
            var spawnPoint = gameContext.GetSpawnAsteroidData().Value.spawnArea.RandomAsteroidSpawnPoint();
            return gameContext.SpawnAsteroid(spawnPoint);
        }
        
        public static GameObject SpawnAsteroid(this IContext gameContext, Vector3 spawnPoint)
        {
            var asteroid = NightPool.Spawn(gameContext.GetSpawnAsteroidData().Value.prefab, spawnPoint, Quaternion.identity, gameContext.GetAsteroidsContainer().Value);
            Debug.Log($"[AsteroidsSpawnerSystem] Spawn {asteroid.name}");
            //IEntityPool coinPool = gameContext.GetCoinSystemData().pool;
            //IEntity coin = coinPool.Rent();
            //coin.GetPosition().Value = spawnPoint;
            return asteroid;
        }
            
        public static Vector3 RandomAsteroidSpawnPoint(this Bounds bounds)
        {
            var positionX = Random.Range(bounds.min.x, bounds.max.x);
            var positionY = Random.Range(bounds.min.y, bounds.max.y);
            var positionZ = bounds.max.z;

            return new Vector3(positionX, positionY, positionZ);
        }
    }
}