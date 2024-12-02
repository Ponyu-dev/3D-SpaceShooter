// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-02
// <file>: IBehaviourInstaller.cs
// ------------------------------------------------------------------------------

using Atomic.Entities;

namespace _Game.GameEngine.Behaviours.Common
{
    public interface IBehaviourInstaller
    {
        void Install(IEntity entity);
    }
}