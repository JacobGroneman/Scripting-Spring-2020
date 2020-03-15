using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfPlayer : MonoBehaviour
{
    public int myAge = 21;
    private int _legalAge = 16;
    
    void Start()
    {
        if (myAge >= _legalAge)
        {
            UnityEngine.Debug.Log("YOU CAN DRIVE!");
        }
        else
        {
            UnityEngine.Debug.Log("YOU CAN'T DRIVE!!");
        }
    }

    
    void Update()
    {
        
    }
}
