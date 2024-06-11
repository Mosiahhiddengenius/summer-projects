using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 5f; // Variable to control how fast the player moves
    public CharacterController controller; // Empty reference to the charactercontroller component on the player

    void Start()
    {
       controller = GetComponent<CharacterController>(); // Get the CharacterController component attached to the plauer 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       float horizontalInput = Input.GetAxis("Horizontal"); // Stores the horizantal (left and right) input of the player
       float verticalInput = Input.GetAxis("Vertical"); // Stores the vertical (Forward and Backward) input of the player

       Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput);

       movement = transform.TransformDirection(movement);

       movement *= movementSpeed;

       controller.Move(movement * Time.deltaTime);
    }
}
