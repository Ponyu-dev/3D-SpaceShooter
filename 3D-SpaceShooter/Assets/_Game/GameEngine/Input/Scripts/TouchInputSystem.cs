// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-02
// <file>: TouchInputSystem.cs
// ------------------------------------------------------------------------------

using Atomic.Contexts;
using Atomic.Elements;
using UnityEngine;
using UnityEngine.InputSystem;

namespace _Game.GameEngine.Input.Scripts
{
    public sealed class TouchInputSystem : IContextInit, IContextEnable, IContextDisable
    {
        private const string StartTouch = "StartTouch";
        private const string UpdateTouch = "UpdateTouch";

        private Const<PlayerInput> _playerInput;
        private IReactiveVariable<Vector3> _deltaMove;
        private IReactiveVariable<bool> _isTouching;
        
        private Vector2 _lastTouchPosition = Vector2.zero;
        private InputAction _startTouchAction;
        private InputAction _updateTouchAction;
        private InputAction _endTouchAction;
        
        public void Init(IContext context)
        {
            _deltaMove = context.GetDeltaMove();
            _isTouching = context.GetIsTouching();
            _playerInput = context.GetPlayerInput();
            
            _startTouchAction = _playerInput.Value.actions.FindAction(StartTouch);
            _updateTouchAction = _playerInput.Value.actions.FindAction(UpdateTouch);
        }
        
        public void Enable(IContext context)
        {
            _startTouchAction.performed += TouchStarted;
            _updateTouchAction.performed += TouchPositionUpdated;
            _startTouchAction.canceled += TouchFinished;
        }
        
        private void TouchStarted(InputAction.CallbackContext context)
        {
            //TODO I haven't figured out yet how to set up the configs in such a way that you get the position of the first touch.
            //_lastTouchPosition = _updateTouchAction.ReadValue<Vector2>();
            _isTouching.Value = true;
        }

        private void TouchPositionUpdated(InputAction.CallbackContext context)
        {
            //TODO It works. But it's a temporary solution.
            if (_lastTouchPosition == Vector2.zero)
                _lastTouchPosition = context.ReadValue<Vector2>();
            
            var currentTouchPosition = context.ReadValue<Vector2>();
            var delta = currentTouchPosition - _lastTouchPosition;
            _lastTouchPosition = currentTouchPosition;
            _deltaMove.Value = new Vector3(delta.x, delta.y, 0).normalized;
        }

        private void TouchFinished(InputAction.CallbackContext context)
        {
            _deltaMove.Value = Vector3.zero;
            _lastTouchPosition = Vector2.zero;
            _isTouching.Value = false;
        }

        public void Disable(IContext context)
        {
            _startTouchAction.performed -= TouchStarted;
            _updateTouchAction.performed -= TouchPositionUpdated;
            _startTouchAction.canceled -= TouchFinished;
        }
    }
}