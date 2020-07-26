using System;
using UnityEngine;

#region Project namespace
using Blitzcrank.Common;
#endregion

namespace Blitzcrank.Manager
{
    public class InputManager : SingletonGameObject<InputManager>
    {
        //heap
        public Action<Vector3> EventPlayerMovementDirectionChanged; 
        private Vector3 _targetMovementVector = Vector3.zero;

        void Update()
        {
            //TODO: Initializing variables in update??
            //stack
            var newVelocity = Vector3.zero;

            var _horizontalMove = Input.GetAxis("Horizontal");
            var _verticalMove = Input.GetAxis("Vertical");

            newVelocity += new Vector3(_horizontalMove, 0f, _verticalMove).normalized;

            if (_targetMovementVector != newVelocity)
            {
                _targetMovementVector = newVelocity;
                EventPlayerMovementDirectionChanged?.Invoke(_targetMovementVector); 
            }
        }
    }
}
