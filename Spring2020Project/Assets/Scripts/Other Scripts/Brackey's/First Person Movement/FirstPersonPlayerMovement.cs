using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonPlayerMovement : MonoBehaviour
{
    //Declarations
    public CharacterController controller;
    public float speed = 12;
    private Vector3 _velocity;
    public float gravity = -9.81f;
    
    public Transform groundChecker;
    public float groundCheckParameter;
    public LayerMask groundMask;
    private bool _isGrounded;

    public float jumpHeight = 3f;

    void Update()
    {
        //Sets Parameters for Ground Checking:
        //(The Transform checking the ground, the Parameter of the transform, the LayerMask it's checking) 
        _isGrounded = Physics.CheckSphere(groundChecker.position, groundCheckParameter, groundMask);

        //Resets Velocity based on the above ground checking mechanism
        if (_isGrounded && _velocity.y < 0)
        {
            _velocity.y = -2f;
        }
        
        //Input for Player Transform.
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        
        //Moves to the Player's Sense of Direction (not world direction)
        Vector3 move = transform.right * x + transform.forward * z;
        
        //Moves the Game Controller Based on the Input
        controller.Move(Time.deltaTime * speed * move);

        //Jumping
        if (Input.GetButtonDown("Jump") && _isGrounded)
        {
            _velocity.y = (float) Math.Sqrt(jumpHeight * -2f * gravity);
        }
        
        //Implements Gravity
        _velocity.y += gravity * Time.deltaTime;
        controller.Move(_velocity * Time.deltaTime);
        
        //Resets Velocity By Ground Checking
    }
}
