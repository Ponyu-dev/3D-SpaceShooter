// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-06
// <file>: StartGamePresenter.cs
// ------------------------------------------------------------------------------

using System;
using Atomic.Contexts;
using Atomic.UI;
using UnityEngine;
using UnityEngine.UI;

namespace _Game.Gameplay.GameCycle.Scripts
{
    [Serializable]
    public sealed class StartGamePresenter : IViewEnable, IViewDisable
    {
        [SerializeField] private SceneContext gameContext;
        [SerializeField] private Button btnStart;
        [SerializeField] private GameObject panelStart;

        public void Enable()
        {
            btnStart.onClick.AddListener(StartGame);
        }

        private void StartGame()
        {
            gameContext.GetIsGamePlay().Value = true;
            panelStart.SetActive(false);
        }

        public void Disable()
        {
            btnStart.onClick.RemoveListener(StartGame);
        }
    }
}