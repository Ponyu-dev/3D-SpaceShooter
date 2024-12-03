// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-03
// <file>: RotateAsteroidsJob.cs
// ------------------------------------------------------------------------------

using _Game.Gameplay.Asteroids.Scripts.Data;
using Unity.Burst;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Jobs;

namespace _Game.Gameplay.Asteroids.Scripts.Jobs
{
    [BurstCompile]
    public struct RotateAsteroidsJob : IJobParallelForTransform
    {
        [ReadOnly] public NativeArray<AsteroidData> AsteroidDataArray;
        [WriteOnly] public float DeltaTime;

        public void Execute(int index, TransformAccess transform)
        {
            var data = AsteroidDataArray[index];
            
            transform.rotation = Quaternion.RotateTowards(
                transform.rotation, 
                transform.rotation * Quaternion.AngleAxis(data.RotationSpeed * DeltaTime, data.RotationAxis), 
                360f);
        }
    }
}