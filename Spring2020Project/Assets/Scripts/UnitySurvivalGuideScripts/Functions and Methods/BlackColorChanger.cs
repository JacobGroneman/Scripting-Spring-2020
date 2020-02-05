using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackColorChanger : MonoBehaviour
{
    public GameObject[] balls;

     void Start()
    {
        balls = ColorThemBlack();
    }
    
    public GameObject[] ColorThemBlack()
    {
        GameObject[] theBalls = GameObject.FindGameObjectsWithTag("Player");

        foreach (var ball in balls)
        {
            ball.GetComponent<MeshRenderer>().material.color = Color.black;
        }
        
        return theBalls;
    }
}
