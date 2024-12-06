// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-06
// <file>: MovementBehaviourInstaller.cs
// ------------------------------------------------------------------------------

using System;
using _Game.GameEngine.Behaviours.Common;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace _Game.GameEngine.Behaviours.Move.Movement
{
    [Serializable]
    public sealed class MovementBehaviourInstaller : IBehaviourInstaller
    {
        [SerializeField] private ReactiveVector3 initialDirection = new(Vector3.zero);
        [SerializeField] private ReactiveFloat moveSpeed = new();
        [SerializeField] private AndExpression canMove;
        
        public void Install(IEntity entity)
        {
            entity.AddMoveSpeed(moveSpeed);
            entity.AddMoveDirection(initialDirection);
            entity.AddCanMove(canMove);
            entity.AddBehaviour<MovementBehaviour>();
        }
        
        public void CanMoveAppend(Func<bool> func)
        {
            canMove.Append(func);
        }

        public Func<bool> IsCaneMove()
        {
            return () => canMove.Value;
        }
    }
}