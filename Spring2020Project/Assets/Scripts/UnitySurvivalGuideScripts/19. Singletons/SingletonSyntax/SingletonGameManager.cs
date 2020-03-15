using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonGameManager : MonoBehaviour
{
    private static SingletonGameManager _instance;

    public static SingletonGameManager Instance
    {
        get
        {
            if (_instance == null)
                Debug.LogError("Error: The Game Manager is null.");
            
            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }

    public void DisplayName()
    {
        Debug.Log("My name is Schnazzle G.");
    }
}
