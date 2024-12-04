// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-03
// <file>: AsteroidsContextInstaller.cs
// ------------------------------------------------------------------------------

using _Game.GameEngine.Common.Scripts;
using _Game.Gameplay.Asteroids.Scripts.Data;
using Atomic.Contexts;
using Atomic.Elements;
using UnityEngine;

namespace _Game.Gameplay.Asteroids.Scripts.Installers
{
    public sealed class AsteroidsContextInstaller : SceneContextInstallerBase
    {
        [SerializeField] private Transform asteroidsContainer;
        [SerializeField] private SpawnAsteroidData spawnAsteroidData;
        [SerializeField] private ReactiveVariable<AsteroidsProperties> reactiveAsteroidsProperties;
        
        public override void Install(IContext context)
        {
            context.AddAsteroidsContainer(new Const<Transform>(asteroidsContainer));
            
            ViewportFunctions.ViewportToWorldBounds(context.GetMainCamera().Value, asteroidsContainer, out var mBounds);
            spawnAsteroidData.spawnArea = mBounds;

            reactiveAsteroidsProperties = new ReactiveVariable<AsteroidsProperties>(new AsteroidsProperties(1));
            context.AddReactiveAsteroidsProperties(reactiveAsteroidsProperties);
            context.AddSpawnAsteroidData(new Const<SpawnAsteroidData>(spawnAsteroidData));
            context.AddSystem<AsteroidsSpawnerSystem>();
            context.AddSystem<AsteroidsRotationSystem>();
        }

        private void OnDestroy()
        {
            reactiveAsteroidsProperties.Value.Dispose();
        }
        
        private void OnDrawGizmos()
        {
            var bounds = spawnAsteroidData.spawnArea;
            var rectBottomLeft = bounds.min;
            var rectBottomRight = new Vector3(bounds.max.x, bounds.min.y, bounds.min.z);
            var rectTopLeft = new Vector3(bounds.min.x, bounds.max.y, bounds.min.z);
            var rectTopRight = bounds.max;
            
            Gizmos.color = Color.gray;
            Gizmos.DrawLine(rectBottomLeft, rectBottomRight);
            Gizmos.DrawLine(rectBottomRight, rectTopRight);
            Gizmos.DrawLine(rectTopRight, rectTopLeft);
            Gizmos.DrawLine(rectTopLeft, rectBottomLeft);
        }
    }
}