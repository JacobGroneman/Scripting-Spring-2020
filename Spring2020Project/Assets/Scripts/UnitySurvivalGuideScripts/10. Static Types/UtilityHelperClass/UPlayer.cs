using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UPlayer : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        { 
            Utility.CreateGameObject();
        }
        if (Input.GetKeyDown(KeyCode.E))
        { 
            Utility.SetPositionZero(this.gameObject);
        }
    }
}
