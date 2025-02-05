// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-04
// <file>: ViewportFunctions.cs
// ------------------------------------------------------------------------------

using Unity.Burst;
using UnityEngine;

namespace _Game.GameEngine.Common.Scripts
{
    [BurstCompile]
    public static class ViewportFunctions
    {
        [BurstCompile]
        public static void ViewportToWorldBounds(
            in Camera mainCamera,
            in Transform root,
            out Bounds bounds)
        {
            var bottomLeft = mainCamera.ViewportToWorldPoint(new Vector3(0f, 0f, root.position.z));
            var topRight = mainCamera.ViewportToWorldPoint(new Vector3(1f, 1f, root.position.z));
            
            bounds = new Bounds();
            bounds.SetMinMax(bottomLeft, topRight);
        }
    }
}