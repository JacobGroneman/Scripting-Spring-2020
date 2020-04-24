using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetSetPractice : MonoBehaviour
{
    [SerializeField]
    private bool _initialized;

    public bool Initialized
    {
        get { return _initialized; }

        set
        {
            if (value == true)
            {
                Debug.Log("System Initialized");
            } 
            _initialized = value;
        }
    }
    
    void Start()
    {
        _initialized = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (Initialized == false)
            {
                Initialized = true;
            }
        }
    }
}
