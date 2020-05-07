using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateController : MonoBehaviour
{
    public float rotationSpeed = 1.0f;
    
    void Start()
    {
       this.transform.rotation = Quaternion.identity; 
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            this.transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            this.transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            this.transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            this.transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
        }
    }
}
