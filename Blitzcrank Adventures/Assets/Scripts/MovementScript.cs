using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public float movementSpeed;
    private Rigidbody rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }
    
    void FixedUpdate()
    {
        float horizontalMovenent = Input.GetAxis("Horizontal");
        float verticalMovenent = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalMovenent, 0.0f, verticalMovenent);
        rigidBody.AddForce (movement * movementSpeed);
    }
}
