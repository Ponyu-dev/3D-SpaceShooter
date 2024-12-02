// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-02
// <file>: TouchInputSystemInstaller.cs
// ------------------------------------------------------------------------------
using System;
using Atomic.Contexts;
using Atomic.Elements;
using UnityEngine;
using UnityEngine.InputSystem;

namespace _Game.GameEngine.Input.Scripts
{
    [Serializable]
    public sealed class TouchInputSystemInstaller : IContextInstaller 
    {
        [SerializeField] private Const<PlayerInput> playerInput;
        [SerializeField] private ReactiveVector3 deltaMove = new(Vector3.zero);
        [SerializeField] private ReactiveBool isTouching = new(false);
        
        public void Install(IContext context)
        {
            context.AddPlayerInput(playerInput);
            context.AddDeltaMove(deltaMove);
            context.AddIsTouching(isTouching);
            context.AddSystem<TouchInputSystem>();
        }
    }
}