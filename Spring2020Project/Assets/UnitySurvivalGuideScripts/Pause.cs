using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Time.timeScale = 0;
        }
        
        if (Input.GetKeyDown(KeyCode.W))
        {
            Time.timeScale = 0.25f;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Time.timeScale = 0.50f;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 0.75f;
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            Time.timeScale = 1;
        }

    }
}
