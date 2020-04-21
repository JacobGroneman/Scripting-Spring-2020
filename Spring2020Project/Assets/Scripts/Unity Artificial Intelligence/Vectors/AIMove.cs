using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMove : MonoBehaviour
{
    private Vector3 _goal = new Vector3(5, 0, 4);
    
    void Update()
    {
        this.transform.Translate(_goal);
    }
}
