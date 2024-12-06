// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-02
// <file>: PlayerContextInstaller.cs
// ------------------------------------------------------------------------------

using _Game.GameEngine.Common.Scripts;
using _Game.Gameplay.GameContext;
using _Game.Gameplay.Player.Scripts.Systems;
using Atomic.Contexts;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace _Game.Gameplay.Player.Scripts.Installers
{
    public sealed class PlayerContextInstaller : SceneContextInstallerBase
    {
        [SerializeField] private SceneEntity playerPrefab;
        [SerializeField] private Const<Bounds> bounds;
        
        public override void Install(IContext context)
        {
            ViewportFunctions.ViewportToWorldBounds(context.GetMainCamera().Value, playerPrefab.transform, out var mBounds);
            bounds = new Const<Bounds>(mBounds);
            
            context.GetPlayerBounds().Value = bounds.Value;
            
            playerPrefab.AddMoveBounds(bounds);
            playerPrefab.Install();

            context.AddPlayerEntity(new Const<IEntity>(playerPrefab));
            context.AddSystem<PlayerMovementSystem>();
            context.AddSystem<GameOverTriggerSystem>();
        }

        private void OnDrawGizmos()
        {
            var rectBottomLeft = bounds.Value.min;
            var rectBottomRight = new Vector3(bounds.Value.max.x, bounds.Value.min.y, bounds.Value.min.z);
            var rectTopLeft = new Vector3(bounds.Value.min.x, bounds.Value.max.y, bounds.Value.max.z);
            var rectTopRight = bounds.Value.max;
            
            Gizmos.color = Color.red;
            Gizmos.DrawLine(rectBottomLeft, rectBottomRight);
            Gizmos.DrawLine(rectBottomRight, rectTopRight);
            Gizmos.DrawLine(rectTopRight, rectTopLeft);
            Gizmos.DrawLine(rectTopLeft, rectBottomLeft);
        }
    }
}