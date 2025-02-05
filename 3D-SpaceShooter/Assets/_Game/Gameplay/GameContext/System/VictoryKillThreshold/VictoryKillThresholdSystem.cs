// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-06
// <file>: VictoryKillThresholdSystem.cs
// ------------------------------------------------------------------------------

using Atomic.Contexts;
using Atomic.Elements;
using Elementary;

namespace _Game.Gameplay.GameContext.System.VictoryKillThreshold
{
    public sealed class VictoryKillThresholdSystem : IContextInit, IContextEnable, IContextDisable
    {
        private BaseEvent<bool> _gameOverEvent;
        private IntVariableLimited _victoryKillThreshold;
        private IReactiveVariable<bool> _isGamePlay;
        
        public void Init(IContext context)
        {
            _gameOverEvent = context.GetGameOverEvent();
            _victoryKillThreshold = context.GetVictoryKillThreshold();
            _isGamePlay = context.GetIsGamePlay();
        }

        public void Enable(IContext context)
        {
            _victoryKillThreshold.OnValueChanged += OnKillValueChanged;
        }

        private void OnKillValueChanged(int current)
        {
            if (!_victoryKillThreshold.IsLimit)
                return;
            
            _gameOverEvent?.Invoke(true);
            _isGamePlay.Value = false;
        }

        public void Disable(IContext context)
        {
            _victoryKillThreshold.OnValueChanged -= OnKillValueChanged;
        }
    }
}