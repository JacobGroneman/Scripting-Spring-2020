using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = System.Diagnostics.Debug;

public class ForLoopBreak : MonoBehaviour
{
    
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            UnityEngine.Debug.Log(i);
            
            if (i == 50);
            {
                break;
            }
        }
    }

    
    void Update()
    {
        
    }
}
