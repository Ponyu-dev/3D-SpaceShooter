// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-03
// <file>: AsteroidsRotationSystem.cs
// ------------------------------------------------------------------------------

using _Game.Gameplay.Asteroids.Scripts.Data;
using _Game.Gameplay.Asteroids.Scripts.Jobs;
using Atomic.Contexts;
using Atomic.Elements;
using UnityEngine;
using UnityEngine.Jobs;

namespace _Game.Gameplay.Asteroids.Scripts
{
    public sealed class AsteroidsRotationSystem : IContextInit, IContextUpdate
    {
        private IReactiveValue<AsteroidsProperties> _asteroidsProperties;
        
        public void Init(IContext context)
        {
            _asteroidsProperties = context.GetReactiveAsteroidsProperties();
        }

        public void Update(IContext context, float deltaTime)
        {
            var job = new RotateAsteroidsJob
            {
                AsteroidDataArray = _asteroidsProperties.Value.NativeAsteroidData,
                DeltaTime = Time.deltaTime
            };
            
            var jobHandle = job.Schedule(_asteroidsProperties.Value.TransformAccessArray);
            jobHandle.Complete();
        }
    }
}