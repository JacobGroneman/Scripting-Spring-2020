using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutThemToZero : MonoBehaviour
{
    public GameObject[] balls;
    
    void Start()
    {
        balls = PositionThemToZero();
    }

    public GameObject[] PositionThemToZero()
    {
        GameObject[] theBalls = GameObject.FindGameObjectsWithTag("Player");
        foreach (var ball in theBalls)
        {
            ball.transform.position = Vector3.zero;
        }
        return theBalls;
    }
}
