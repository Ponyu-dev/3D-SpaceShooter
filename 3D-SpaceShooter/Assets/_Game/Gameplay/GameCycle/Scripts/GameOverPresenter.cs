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
        [SerializeField] private GameObject panelDied;
        [SerializeField] private GameObject panelWinner;

        public void Enable()
        {
            gameContext.GetGameOverEvent().Subscribe(ShowGameOver);
            btnRestart.onClick.AddListener(RestartGame);
        }

        public void ShowGameOver(bool isVictory)
        {
            panelGameOver.SetActive(true);
            panelDied.SetActive(!isVictory);
            panelWinner.SetActive(isVictory);
        }

        private void RestartGame()
        {
            panelGameOver.SetActive(false);
            panelDied.SetActive(false);
            panelWinner.SetActive(false);
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