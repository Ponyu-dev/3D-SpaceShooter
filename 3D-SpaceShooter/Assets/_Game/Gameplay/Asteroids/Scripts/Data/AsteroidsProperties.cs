// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-03
// <file>: AsteroidsProperties.cs
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Sirenix.Serialization;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

namespace _Game.Gameplay.Asteroids.Scripts.Data
{
    [Serializable]
    public sealed class AsteroidsProperties : IDisposable
    {
        [SerializeField] private NativeArray<AsteroidData> asteroidData;
        public NativeArray<AsteroidData> NativeAsteroidData => asteroidData;

        [SerializeField] public TransformAccessArray transformAccessArray;
        public TransformAccessArray TransformAccessArray => transformAccessArray;
        
        public AsteroidsProperties(int initialCapacity)
        {
            asteroidData = new NativeArray<AsteroidData>(initialCapacity, Allocator.Persistent);
            transformAccessArray = new TransformAccessArray(initialCapacity);
        }

        public int SpawnAsteroid(Transform newTransform)
        {
            // Добавляем Transform в TransformAccessArray
            transformAccessArray.Add(newTransform);

            // Увеличиваем NativeArray, если нужно
            if (asteroidData.Length < transformAccessArray.length)
            {
                var newAsteroidData = new NativeArray<AsteroidData>(transformAccessArray.length, Allocator.Persistent);
                NativeArray<AsteroidData>.Copy(asteroidData, newAsteroidData, asteroidData.Length);
                asteroidData.Dispose();
                asteroidData = newAsteroidData;
            }

            // Генерируем данные для нового астероида
            var newIndex = transformAccessArray.length - 1;
            asteroidData[newIndex] = new AsteroidData(
                new Vector3(Random.value, Random.value, Random.value).normalized,
                Random.Range(10f, 50f));

            return newIndex; // Возвращаем индекс нового элемента
        }

        public void UnSpawnAsteroid(int index)
        {
            if (index < 0 || index >= transformAccessArray.length)
                throw new ArgumentOutOfRangeException(nameof(index), "Invalid index for UnSpawnAsteroid.");

            // Удаляем Transform из TransformAccessArray
            transformAccessArray.RemoveAtSwapBack(index);

            // Переносим последний элемент в место удаленного
            var lastIndex = asteroidData.Length - 1;
            if (index < lastIndex)
            {
                asteroidData[index] = asteroidData[lastIndex];
            }

            // Уменьшаем размер массива
            var newAsteroidData = new NativeArray<AsteroidData>(lastIndex, Allocator.Persistent);
            NativeArray<AsteroidData>.Copy(asteroidData, newAsteroidData, lastIndex);
            asteroidData.Dispose();
            asteroidData = newAsteroidData;
        }

        public void Dispose()
        {
            asteroidData.Dispose();
            transformAccessArray.Dispose();
        }
    }
}