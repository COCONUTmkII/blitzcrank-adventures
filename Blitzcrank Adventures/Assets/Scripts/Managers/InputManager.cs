using System;
using Common;
using UnityEngine;

namespace Managers
{
    public class InputManager : SingletonGameObject<InputManager>
    {
        public Action<Vector3> eventPlayerMovementDirectionChanged;
        private Vector3 _targetMovementVector = Vector3.zero;

        void Update()
        {
            var newVelocity = Vector3.zero;

            var horizontalMove = Input.GetAxis("Horizontal");
            var verticalMove = Input.GetAxis("Vertical");
            newVelocity += new Vector3(horizontalMove, 0f, verticalMove).normalized;
            
            if (_targetMovementVector != newVelocity)
            {
                _targetMovementVector = newVelocity;
                eventPlayerMovementDirectionChanged?.Invoke(_targetMovementVector);
            }
        }
    }
}
