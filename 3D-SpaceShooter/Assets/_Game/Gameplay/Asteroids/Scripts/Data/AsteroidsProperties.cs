// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-03
// <file>: AsteroidsProperties.cs
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using NTC.Pool;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Jobs;
using Random = UnityEngine.Random;

namespace _Game.Gameplay.Asteroids.Scripts.Data
{
    [Serializable]
    public sealed class AsteroidsProperties : IDisposable
    {
        private Dictionary<Transform, int> _transformToIndexMap = new();
        
        [SerializeField] private NativeArray<AsteroidData> asteroidData;
        public NativeArray<AsteroidData> NativeAsteroidData => asteroidData;

        [SerializeField] public TransformAccessArray transformAccessArray;
        public TransformAccessArray TransformAccessArray => transformAccessArray;
        
        public AsteroidsProperties(int initialCapacity)
        {
            asteroidData = new NativeArray<AsteroidData>(initialCapacity, Allocator.Persistent);
            transformAccessArray = new TransformAccessArray(initialCapacity);
        }

        public void SpawnAsteroid(Transform newTransform, Vector3 positionDirection)
        {
            if (_transformToIndexMap.ContainsKey(newTransform))
                throw new InvalidOperationException("Transform уже зарегистрирован.");
            
            // Добавляем Transform в TransformAccessArray
            transformAccessArray.Add(newTransform);
            var newIndex = transformAccessArray.length - 1;
            _transformToIndexMap[newTransform] = newIndex;

            // Увеличиваем NativeArray, если нужно
            if (asteroidData.Length < transformAccessArray.length)
            {
                var newAsteroidData = new NativeArray<AsteroidData>(transformAccessArray.length, Allocator.Persistent);
                NativeArray<AsteroidData>.Copy(asteroidData, newAsteroidData, asteroidData.Length);
                asteroidData.Dispose();
                asteroidData = newAsteroidData;
            }

            // Генерируем данные для нового астероида
            asteroidData[newIndex] = new AsteroidData(
                new Vector3(Random.value, Random.value, Random.value).normalized,
                Random.Range(10f, 50f),
                -positionDirection.normalized,
                Random.Range(1f, 10f));
        }

        public void DespawnAsteroid(Transform transform)
        {
            if (!_transformToIndexMap.TryGetValue(transform, out var index))
                throw new ArgumentException("Transform не найден.");
            
            NightPool.Despawn(transformAccessArray[index].gameObject);
            
            // Удаляем Transform из TransformAccessArray
            transformAccessArray.RemoveAtSwapBack(index);

            // Переносим последний элемент в место удаленного
            var lastIndex = asteroidData.Length - 1;
            if (index < lastIndex)
            {
                asteroidData[index] = asteroidData[lastIndex];
                var lastTransform = transformAccessArray[index];
                _transformToIndexMap[lastTransform] = index;
            }

            // Уменьшаем размер массива
            var newAsteroidData = new NativeArray<AsteroidData>(lastIndex, Allocator.Persistent);
            NativeArray<AsteroidData>.Copy(asteroidData, newAsteroidData, lastIndex);
            asteroidData.Dispose();
            asteroidData = newAsteroidData;
            
            _transformToIndexMap.Remove(transform);
        }

        public void Dispose()
        {
            asteroidData.Dispose();
            transformAccessArray.Dispose();
        }
    }
}