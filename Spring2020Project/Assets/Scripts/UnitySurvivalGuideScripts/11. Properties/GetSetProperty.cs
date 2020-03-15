using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetSetProperty : MonoBehaviour
{
    private bool isGameOver;

    public bool IsGameOver
    {
        get { return isGameOver; }
        set { if (value == true) {UnityEngine.Debug.Log("The Game Is Over");} isGameOver = value;}
    }

    private void Start()
    {
        IsGameOver = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            IsGameOver = true;
        }
    }
}
