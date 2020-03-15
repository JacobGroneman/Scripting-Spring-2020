using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutThemToZero : MonoBehaviour
{
    public GameObject[] balls;
    
    void Start()
    { 
        PositionThemToZero();
    }

    public GameObject[] PositionThemToZero()
    {
        balls = GameObject.FindGameObjectsWithTag("Player");
        foreach (var ball in balls)
        {
            ball.transform.position = Vector3.zero;
        }
        return balls;
    }
}
