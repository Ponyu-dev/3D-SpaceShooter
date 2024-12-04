// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-03
// <file>: AsteroidsContextInstaller.cs
// ------------------------------------------------------------------------------

using _Game.GameEngine.Common.Scripts;
using Atomic.Contexts;
using Atomic.Elements;
using UnityEngine;

namespace _Game.Gameplay.Asteroids.Scripts.Installers
{
    public sealed class AsteroidsContextInstaller : SceneContextInstallerBase
    {
        [SerializeField] private Transform asteroidsContainer;
        [SerializeField] private Const<Bounds> bounds;
        
        //[SerializeField] private Transform[] asteroids;
        //[SerializeField] private ReactiveVariable<AsteroidsProperties> reactiveAsteroidsProperties;
        
        public override void Install(IContext context)
        {
            context.AddAsteroidsContainer(new Const<Transform>(asteroidsContainer));
            
            ViewportFunctions.ViewportToWorldBounds(context.GetMainCamera().Value, asteroidsContainer, out var mBounds);
            bounds = new Const<Bounds>(mBounds);
            context.AddAsteroidsBounds(bounds);
        }
        
        /*var asteroidData = new NativeArray<AsteroidData>(asteroids.Length, Allocator.Persistent);
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
            context.AddSystem<AsteroidsRotationSystem>();*/

        private void OnDestroy()
        {
            //reactiveAsteroidsProperties.Value.Dispose();
        }
        
        

        private void OnDrawGizmos()
        {
            var rectBottomLeft = bounds.Value.min;
            var rectBottomRight = new Vector3(bounds.Value.max.x, bounds.Value.min.y, bounds.Value.min.z);
            var rectTopLeft = new Vector3(bounds.Value.min.x, bounds.Value.max.y, bounds.Value.min.z);
            var rectTopRight = bounds.Value.max;
            
            Gizmos.color = Color.gray;
            Gizmos.DrawLine(rectBottomLeft, rectBottomRight);
            Gizmos.DrawLine(rectBottomRight, rectTopRight);
            Gizmos.DrawLine(rectTopRight, rectTopLeft);
            Gizmos.DrawLine(rectTopLeft, rectBottomLeft);
        }
    }
}