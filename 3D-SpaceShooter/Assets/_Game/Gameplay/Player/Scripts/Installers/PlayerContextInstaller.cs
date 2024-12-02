// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-02
// <file>: PlayerContextInstaller.cs
// ------------------------------------------------------------------------------

using _Game.GameEngine.Input.Scripts;
using Atomic.Contexts;
using UnityEngine;

namespace _Game.Gameplay.Player.Scripts.Installers
{
    public sealed class PlayerContextInstaller : SceneContextInstallerBase
    {
        [SerializeField] private TouchInputSystemInstaller touchInputSystemInstaller;
        
        public override void Install(IContext context)
        {
            touchInputSystemInstaller.Install(context);
        }
    }
}