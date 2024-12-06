// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-06
// <file>: GameOverPresenter.cs
// ------------------------------------------------------------------------------

using System;
using Atomic.Contexts;
using Atomic.UI;
using UnityEngine;
using UnityEngine.UI;

namespace _Game.Gameplay.GameCycle.Scripts
{
    [Serializable]
    public sealed class GameOverPresenter : IViewEnable, IViewDisable
    {
        [SerializeField] private SceneContext gameContext;
        [SerializeField] private Button btnRestart;
        [SerializeField] private GameObject panelGameOver;
        
        public void Enable()
        {
            gameContext.GetGameOverEvent().Subscribe(ShowGameOver);
            btnRestart.onClick.AddListener(RestartGame);
        }

        public void ShowGameOver()
        {
            panelGameOver.SetActive(true);
        }

        private void RestartGame()
        {
            panelGameOver.SetActive(false);
            gameContext.GetIsGamePlay().Value = true;
            gameContext.GetRestartEvent().Invoke();
        }

        public void Disable()
        {
            gameContext.GetGameOverEvent().Unsubscribe(ShowGameOver);
            btnRestart.onClick.RemoveListener(RestartGame);
        }
    }
}