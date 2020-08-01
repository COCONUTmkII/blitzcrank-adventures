using System;
using Blitzcrank.Manager.Input;
using Managers.InputButtons;
using UnityEngine;

#region Project namespace
using Blitzcrank.Common;
#endregion

namespace Blitzcrank.Managers
{
    public class InputManager : SingletonGameObject<InputManager>
    {
        public Action<Vector3> eventPlayerMovementDirectionChanged; 
        private Vector3 _targetMovementVector = Vector3.zero;
        private Vector3 _newVelocity;
        void Update()
        {
            HandleInput();
            _newVelocity = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")).normalized;
            if (_targetMovementVector != _newVelocity)
            {
                _targetMovementVector = _newVelocity;
                eventPlayerMovementDirectionChanged?.Invoke(_targetMovementVector); 
            }
        }

        private void HandleInput()
        {
            foreach(KeyCode currentKeyCode in Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKeyDown(currentKeyCode))
                {
                    InputCommand command = InputButtonListener.CheckInputButton(currentKeyCode);
                    command.Execute();
                }
            }
        }
    }
}
