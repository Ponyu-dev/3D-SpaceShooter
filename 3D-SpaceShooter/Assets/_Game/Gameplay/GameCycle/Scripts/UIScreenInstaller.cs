// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-06
// <file>: UIScreenInstaller.cs
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using _Game.Gameplay.GameContext.System.KillThresholdView;
using Atomic.UI;
using Atomic.UI.Installer;
using UnityEngine;

namespace _Game.Gameplay.GameCycle.Scripts
{
    public sealed class UIScreenInstaller : SceneViewControllerInstaller
    {
        [SerializeField] private KillThresholdPresenter killThresholdPresenter;
        [SerializeField] private StartGamePresenter startGamePresenter;
        [SerializeField] private GameOverPresenter gameOverPresenter;
        
        protected override IEnumerable<IViewController> GetControllers()
        {
            yield return killThresholdPresenter;
            yield return startGamePresenter;
            yield return gameOverPresenter;
        }
    }
}