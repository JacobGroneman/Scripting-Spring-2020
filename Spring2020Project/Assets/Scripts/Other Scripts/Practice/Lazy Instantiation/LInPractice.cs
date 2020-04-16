using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LInPractice : MonoBehaviour
{
    private static LInPractice _instance;

    public static LInPractice Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject gameObj = new GameObject("Manager");
                gameObj.AddComponent<LInPractice>();
            }
            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }

    public void Method()
    {
        Debug.Log("Executing Method");
    }
}