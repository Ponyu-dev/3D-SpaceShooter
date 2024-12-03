// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-03
// <file>: AsteroidsProperties.cs
// ------------------------------------------------------------------------------

using System;
using Unity.Collections;
using UnityEngine.Jobs;

namespace _Game.Gameplay.Asteroids.Scripts.Data
{
    [Serializable]
    public sealed class AsteroidsProperties : IDisposable
    {
        public NativeArray<AsteroidData> AsteroidData { get; private set; }
        public TransformAccessArray TransformAccessArray { get; private set; }
        

        public AsteroidsProperties(NativeArray<AsteroidData> asteroidData, TransformAccessArray transformAccessArray)
        {
            AsteroidData = asteroidData;
            TransformAccessArray = transformAccessArray;
        }

        public void Dispose()
        {
            AsteroidData.Dispose();
            TransformAccessArray.Dispose();
        }
    }
}