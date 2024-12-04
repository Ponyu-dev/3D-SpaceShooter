// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-03
// <file>: TestAsteroidSpawner.cs
// ------------------------------------------------------------------------------

using UnityEngine;

namespace _Game.Gameplay.Asteroids.Scripts
{
    public sealed class TestAsteroidSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject asteroidPrefab; // Префаб астероида
        [SerializeField] private float spawnInterval = 1f; // Интервал спавна

        [SerializeField] private CameraBoundsVisualizer playerCameraBoundsVisualizer;
        [SerializeField] private CameraBoundsVisualizer asteroidsCameraBoundsVisualizer;

        private Bounds _asteroidsBounds;
        private Bounds _playerBounds;
        
        private void Start()
        {
            _asteroidsBounds = asteroidsCameraBoundsVisualizer.GetBounds();
            _playerBounds = playerCameraBoundsVisualizer.GetBounds();
            
            InvokeRepeating("SpawnAsteroid", 0f, spawnInterval);
        }

        private void SpawnAsteroid()
        {
            // Генерируем случайную позицию для астероида только впереди игрока
            var randomX = Random.Range(_asteroidsBounds.min.x, _asteroidsBounds.max.x);
            var randomY = Random.Range(_asteroidsBounds.min.y, _asteroidsBounds.max.y);
            
            // Устанавливаем спавн-позицию астероида в пределах камеры
            var spawnPosition = new Vector3(randomX, randomY, _asteroidsBounds.max.z);
            // Создаём астероида
            var asteroid = Instantiate(asteroidPrefab, spawnPosition, Quaternion.identity, transform);
            
            var playerRandomX = Random.Range(_playerBounds.min.x, _playerBounds.max.x);
            var playerRandomY = Random.Range(_playerBounds.min.y, _playerBounds.max.y);
            var playerRandomZ = Random.Range(_playerBounds.min.z, _playerBounds.max.z);
            var direction = new Vector3(playerRandomX, playerRandomY, playerRandomZ);
            
            if (asteroid.TryGetComponent<AsteroidsGizmos>(out var gizmos))
            {
                gizmos.spawnPosition = spawnPosition;
                gizmos.directionPosition = direction;
            }
        }
    }
}