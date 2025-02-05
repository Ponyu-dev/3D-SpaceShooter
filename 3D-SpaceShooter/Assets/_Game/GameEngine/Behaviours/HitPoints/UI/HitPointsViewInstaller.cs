// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-05
// <file>: HitPointsViewInstaller.cs
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Atomic.UI;
using Atomic.UI.Installer;
using UnityEngine;

namespace _Game.GameEngine.Behaviours.HitPoints.UI
{
    public sealed class HitPointsViewInstaller : SceneViewControllerInstaller
    {
        [SerializeField] private HitPointsViewPresenter hitPointsViewPresenter; 
        
        protected override IEnumerable<IViewController> GetControllers()
        {
            yield return hitPointsViewPresenter;
        }
    }
}