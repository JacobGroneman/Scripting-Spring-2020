using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position : MonoBehaviour
{
    public Vector3 startPosition;
    
    void Start()
    {
        transform.position = startPosition;
    }
}
