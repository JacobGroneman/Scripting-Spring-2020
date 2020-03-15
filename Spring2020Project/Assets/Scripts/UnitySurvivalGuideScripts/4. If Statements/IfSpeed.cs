using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class IfSpeed : MonoBehaviour
{
    public int speed = 0;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            speed += 5;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            speed -= 5;
        }

        if (speed > 20)
        {
            UnityEngine.Debug.Log("Slow Down!");
        }
        else if (speed == 0)
        {
            UnityEngine.Debug.Log("Speed Up!");
        }

        if (speed < 0)
        {
            speed = 0;
        }
    }
}
