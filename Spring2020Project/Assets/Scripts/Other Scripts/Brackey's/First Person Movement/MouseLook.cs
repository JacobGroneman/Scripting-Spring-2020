using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    //Declarations
    public float mouseSensitivity = 100f;
    public Transform playerBody;
    public float xRotation = 0f;
    
    void Start()
    {
        //Cursor lock for Center Mouse Control
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        //Declaring Mouse Input Directions
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        
        //Down-Up Rotation Limit
        xRotation = Mathf.Clamp(xRotation, -90, 90);
        
        //Vertical Rotation
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        
        //Horizontal Rotation
        playerBody.Rotate(Vector3.up * mouseX);

    }
}
