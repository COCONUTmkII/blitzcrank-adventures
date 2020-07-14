using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovementBehaviour : MonoBehaviour
{
    [SerializeField] private float _movementSpeed = 15f;
    [SerializeField] float _velocityChangeSpeed = 15f;
    private Vector3 _targetMovementVelocity = Vector3.zero;
    private Vector3 _currentMovementVelocity;
    private Rigidbody _rigidBody;

    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        _currentMovementVelocity = Vector3.Lerp(
        _currentMovementVelocity, _targetMovementVelocity * _movementSpeed, _velocityChangeSpeed * Time.deltaTime);
    }
    void FixedUpdate()
    {
        // float horizontalMovenent = Input.GetAxis("Horizontal");
        // float verticalMovenent = Input.GetAxis("Vertical");

        // Vector3 movement = new Vector3(horizontalMovenent, 0.0f, verticalMovenent);
        // rigidBody.AddForce (movement * movementSpeed);

        _rigidBody.velocity = new Vector3(_currentMovementVelocity.x, _rigidBody.velocity.y, _currentMovementVelocity.z);
    }

    public void ChangeCharacterMovementDirection (Vector3 targetDirection)
    {
        _targetMovementVelocity = targetDirection.normalized;
    }
}
