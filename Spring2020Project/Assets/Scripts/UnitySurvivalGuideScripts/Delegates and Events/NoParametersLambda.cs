using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoParametersLambda : MonoBehaviour
{
    public Action onGetName;
    void Start()
    {
        onGetName = () =>
        {
            Debug.Log("Game Object Name: " + name);
            Debug.Log("It's a nice Day Y'all!");
        };
            
        onGetName?.Invoke();
    }
}
