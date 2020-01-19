using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfPointPlayer : MonoBehaviour
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
    }
}
