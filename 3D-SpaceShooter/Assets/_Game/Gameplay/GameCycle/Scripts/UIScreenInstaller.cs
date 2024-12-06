// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-06
// <file>: UIScreenInstaller.cs
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using Atomic.UI;
using Atomic.UI.Installer;
using UnityEngine;

namespace _Game.Gameplay.GameCycle.Scripts
{
    public sealed class UIScreenInstaller : SceneViewControllerInstaller
    {
        [SerializeField] private StartGamePresenter startGamePresenter;
        
        protected override IEnumerable<IViewController> GetControllers()
        {
            yield return startGamePresenter;
        }
    }
}