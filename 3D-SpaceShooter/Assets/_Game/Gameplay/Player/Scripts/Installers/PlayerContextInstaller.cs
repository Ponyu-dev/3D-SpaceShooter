// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-02
// <file>: PlayerContextInstaller.cs
// ------------------------------------------------------------------------------

using _Game.GameEngine.Input.Scripts;
using _Game.Gameplay.Player.Scripts.Systems;
using Atomic.Contexts;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace _Game.Gameplay.Player.Scripts.Installers
{
    public sealed class PlayerContextInstaller : SceneContextInstallerBase
    {
        [SerializeField] private SceneEntity playerEntity;
        [SerializeField] private TouchInputSystemInstaller touchInputSystemInstaller;
        
        public override void Install(IContext context)
        {
            context.AddPlayerEntity(new Const<IEntity>(playerEntity));
            
            touchInputSystemInstaller.Install(context);
            context.AddSystem<PlayerMovementSystem>();
        }
    }
}