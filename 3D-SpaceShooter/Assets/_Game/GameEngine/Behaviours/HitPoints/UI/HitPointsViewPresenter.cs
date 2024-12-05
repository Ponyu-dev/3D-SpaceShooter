// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-05
// <file>: HitPointsViewPresenter.cs
// ------------------------------------------------------------------------------

using System;
using Atomic.Entities;
using Atomic.UI;
using Elementary;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace _Game.GameEngine.Behaviours.HitPoints.UI
{
    [Serializable]
    public sealed class HitPointsViewPresenter : IViewInit, IViewEnable, IViewDisable
    {
        [SerializeField] private SceneEntity entity;
        [SerializeField] private TextMeshProUGUI textHp;
        [SerializeField] private Image fillHp;

        private IVariableLimited<int> _hitPoints;
        
        public void Init()
        {
            _hitPoints = entity.GetHitPoint();
        }

        public void Enable()
        {
            _hitPoints.OnValueChanged += OnHPValueChanged;
        }

        private void OnHPValueChanged(int currentHealth)
        {
            var healthRatio = (float)currentHealth / _hitPoints.MaxValue;
            fillHp.fillAmount = healthRatio;
            textHp.text = $"{healthRatio * 100f:F1}%";
        }

        public void Disable()
        {
            _hitPoints.OnValueChanged -= OnHPValueChanged;
        }
    }
}