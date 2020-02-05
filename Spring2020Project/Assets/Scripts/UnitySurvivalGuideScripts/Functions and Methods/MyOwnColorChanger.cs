using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyOwnColorChanger : MonoBehaviour
{
    public GameObject[] ballBasket;
    
    void Start()
    {
        ballBasket = ColorThem();
    }

    GameObject[] ColorThem()
    {
        GameObject[] balls = GameObject.FindGameObjectsWithTag("Player");
        
        foreach (var ball in balls)
        {
            ball.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
        }
        
        return balls;
    }
}
