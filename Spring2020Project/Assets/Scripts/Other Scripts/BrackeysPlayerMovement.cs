using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class BrackeysPlayerMovement : MonoBehaviour
{
    public CharacterController controller; 
    [SerializeField] private float horizontalMove = 0f;
    public float runSpeed = 40f;
    [SerializeField] private bool _jump = false;
    [SerializeField] private bool _crouch = false;
    
    void Start()
    {
        
    }

   
    void Update()
    {
       horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
       if (Input.GetButtonDown("Jump"));
       {
           _jump = true;
       }
       if (Input.GetButtonDown("Crouch"));
       {
           _crouch = true;
       } 
       else if (Input.GetButtonUp("Crouch"))
       {
           _crouch = false;
       }
    }

    private void FixedUpdate()
    {
        controller.Move(new Vector3(horizontalMove * Time.fixedDeltaTime, _crouch, _jump));
        _jump = false;
    }
}
