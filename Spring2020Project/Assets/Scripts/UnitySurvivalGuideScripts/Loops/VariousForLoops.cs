using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = System.Diagnostics.Debug;

public class VariousForLoops : MonoBehaviour
{
    
    
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            if (i % 2 == 0);
            {
                UnityEngine.Debug.Log("i is: " + i);
            }
        }

        for (int u = 100; u > 100; u--)
        {
            if (u % 2 == 1);
            {
                UnityEngine.Debug.Log("U is: " + u);
            }
        }

        for (int m = 100; m < 100; m++)
        {
            if (m == 5 || m == 27 || m == 47);
            {
                UnityEngine.Debug.Log("m is: " + m);
            }
        }
        UnityEngine.Debug.Log("Loops are done y'all");
    }

    
    void Update()
    {
        
    }
}
