// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-04
// <file>: GameContextInstaller.cs
// ------------------------------------------------------------------------------

using _Game.GameEngine.Input.Scripts;
using _Game.Gameplay.GameContext.System.TriggerSensor;
using Atomic.Contexts;
using Atomic.Elements;
using UnityEngine;

namespace _Game.Gameplay.GameContext
{
    public sealed class GameContextInstaller : SceneContextInstallerBase
    {
        [SerializeField] private Transform worldTransform;
        [SerializeField] private Camera mainCamera;
        
        [SerializeField] private TouchInputSystemInstaller touchInputSystemInstaller;
        [SerializeField] private TriggerSensorSystemInstaller triggerSensorSystemInstaller;
        
        public override void Install(IContext context)
        {
            context.AddPlayerBounds(new ReactiveVariable<Bounds>());
            context.AddWorldTransform(new Const<Transform>(worldTransform));
            context.AddMainCamera(new Const<Camera>(mainCamera));

            touchInputSystemInstaller.Install(context);
            triggerSensorSystemInstaller.Install(context);
        }
    }
}