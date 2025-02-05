// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-06
// <file>: KillThresholdPresenter.cs
// ------------------------------------------------------------------------------

using System;
using Atomic.Contexts;
using Atomic.UI;
using Elementary;
using TMPro;
using UnityEngine;

namespace _Game.Gameplay.GameContext.System.KillThresholdView
{
    [Serializable]
    public sealed class KillThresholdPresenter : IViewInit, IViewEnable, IViewDisable
    {
        [SerializeField] private TextMeshProUGUI txtKillThreshold;

        private IntVariableLimited _victoryKillThreshold;
        
        public void Init()
        {
            _victoryKillThreshold = SingletonGameContext.Instance.GetVictoryKillThreshold();
        }
        
        public void Enable()
        {
            _victoryKillThreshold.OnValueChanged += OnKillValueChanged;
            OnKillValueChanged(_victoryKillThreshold.Current);
        }

        private void OnKillValueChanged(int current)
        {
            var text = $"{current} / {_victoryKillThreshold.MaxValue}";
            txtKillThreshold.text = text;
        }

        public void Disable()
        {
            _victoryKillThreshold.OnValueChanged -= OnKillValueChanged;
        }
    }
}