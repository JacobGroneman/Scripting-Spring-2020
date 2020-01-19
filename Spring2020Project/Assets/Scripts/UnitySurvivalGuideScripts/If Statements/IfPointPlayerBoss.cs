using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfPointPlayerBoss : MonoBehaviour
{
    [SerializeField]
    private int _points;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _points += 10;
        }

        if (_points >= 50)
        {
            UnityEngine.Debug.Log("You are Awesome");
        }
    }
}
