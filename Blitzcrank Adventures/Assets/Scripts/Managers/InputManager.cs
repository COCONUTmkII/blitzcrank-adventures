using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : SingletonGameObject<InputManager>
{
    public Action<Vector3> EventPlayerMovementDirectionChanged;
    private Vector3 _targetMovementVector = Vector3.zero;

    void Update()
    {
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
