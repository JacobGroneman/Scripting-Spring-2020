using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputRotation : MonoBehaviour
{
    public GameObject cube;
    public Quaternion rotation;

    void Update()
    {
        cube.transform.rotation = rotation;
        
        if (Input.GetKey(KeyCode.D))
        {
            rotation.x++;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rotation.x--;
        }

        if (Input.GetKey(KeyCode.W))
        {
            rotation.y++;
        }

        if (Input.GetKey(KeyCode.S))
        {
            rotation.y--;
        }
    }
}
