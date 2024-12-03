// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-03
// <file>: AsteroidsContextInstaller.cs
// ------------------------------------------------------------------------------

using _Game.Gameplay.Asteroids.Scripts.Data;
using Atomic.Contexts;
using Atomic.Elements;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Jobs;
using Random = UnityEngine.Random;

namespace _Game.Gameplay.Asteroids.Scripts.Installers
{
    public sealed class AsteroidsContextInstaller : SceneContextInstallerBase
    {
        [SerializeField] private Transform[] asteroids;

        [SerializeField] private ReactiveVariable<AsteroidsProperties> reactiveAsteroidsProperties;
        
        public override void Install(IContext context)
        {
            //TODO перенести в отдельный метод.
            var asteroidData = new NativeArray<AsteroidData>(asteroids.Length, Allocator.Persistent);
            var transformAccessArray = new TransformAccessArray(asteroids);

            for (var i = 0; i < asteroids.Length; i++)
            {
                asteroidData[i] = new AsteroidData
                (
                    new Vector3(Random.value, Random.value, Random.value).normalized,
                    Random.Range(10f, 50f)
                );
            }
            reactiveAsteroidsProperties = new ReactiveVariable<AsteroidsProperties>(new AsteroidsProperties(asteroidData, transformAccessArray));

            context.AddReactiveAsteroidsProperties(reactiveAsteroidsProperties);

            context.AddSystem<AsteroidsRotationSystem>();
        }

        private void OnDestroy()
        {
            reactiveAsteroidsProperties.Value.Dispose();
        }
    }
}