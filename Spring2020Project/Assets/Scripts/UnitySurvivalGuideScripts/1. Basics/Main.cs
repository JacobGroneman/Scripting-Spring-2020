using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            UnityEngine.Debug.Log("pressed the space bar.");
        }
        
        if (Input.GetKey(KeyCode.E))
        {
            UnityEngine.Debug.Log("Holding E");
        }

        if (Input.GetKeyUp(KeyCode.F))
        {
            UnityEngine.Debug.Log("F got Pressed");
        }
    }
}
