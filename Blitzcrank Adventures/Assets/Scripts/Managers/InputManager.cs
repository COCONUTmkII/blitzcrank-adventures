using System;
using UnityEngine;

#region Project namespace
using Blitzcrank.Common;
#endregion

namespace Blitzcrank.Manager
{
    public class InputManager : SingletonGameObject<InputManager>
    {
        public Action<Vector3> EventPlayerMovementDirectionChanged; 
        private Vector3 _targetMovementVector = Vector3.zero;
        private Vector3 _newVelocity;

        void Update()
        {
            //Fix
            //var newVelocity = Vector3.zero;
            //var _horizontalMove = Input.GetAxis("Horizontal");
            //var _verticalMove = Input.GetAxis("Vertical");
            //newVelocity += new Vector3(_horizontalMove, 0f, _verticalMove).normalized;
            _newVelocity = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")).normalized;
            if (_targetMovementVector != _newVelocity)
            {
                _targetMovementVector = _newVelocity;
                EventPlayerMovementDirectionChanged?.Invoke(_targetMovementVector); 
            }
            
        }
    }
}
