// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-03
// <file>: CameraBoundsVisualizer.cs
// ------------------------------------------------------------------------------

using UnityEngine;

namespace _Game.Gameplay.Asteroids.Scripts
{
    public class CameraBoundsVisualizer : MonoBehaviour
    {
        [SerializeField] private Color colorRectangle;
        [SerializeField] private Camera mainCamera;  // Камера, для которой будем рисовать границы
        
        [SerializeField] private Vector3 bottomLeft;
        [SerializeField] private Vector3 bottomRight;
        [SerializeField] private Vector3 topLeft;
        [SerializeField] private Vector3 topRight;

        [SerializeField] private Bounds bounds;

        public Bounds GetBounds() => bounds;
        
        private void OnDrawGizmos()
        {
            if (mainCamera == null)
                return;
            
            // Расчёт углов видимости в мировых координатах
            bottomLeft = mainCamera.ViewportToWorldPoint(new Vector3(0f, 0f, transform.position.z));
            bottomRight = mainCamera.ViewportToWorldPoint(new Vector3(1f, 0f, transform.position.z));
            topLeft = mainCamera.ViewportToWorldPoint(new Vector3(0f, 1f, transform.position.z));
            topRight = mainCamera.ViewportToWorldPoint(new Vector3(1f, 1f, transform.position.z));
            
            bounds = new Bounds();
            bounds.SetMinMax(bottomLeft, topRight);

            // Рисуем прямоугольник
            Gizmos.color = colorRectangle;
            Gizmos.DrawLine(bottomLeft, bottomRight); // Нижняя сторона
            Gizmos.DrawLine(bottomRight, topRight);  // Правая сторона
            Gizmos.DrawLine(topRight, topLeft);      // Верхняя сторона
            Gizmos.DrawLine(topLeft, bottomLeft);    // Левая сторона
            
            // Визуализируем центр
            // Центр на расстоянии zDistance перед камерой
            Gizmos.color = Color.red;
            Gizmos.DrawSphere(bounds.center, 0.5f); // Центр в пространстве
        }
    }
}