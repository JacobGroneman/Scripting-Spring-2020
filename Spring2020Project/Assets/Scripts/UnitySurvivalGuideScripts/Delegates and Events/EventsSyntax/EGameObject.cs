using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EGameObject : MonoBehaviour
{
    void Start()
    {
        EMain.onClick += TurnRed;
    }

    private void TurnRed()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }

    private void OnDisable()
    {
        EMain.onClick -= TurnRed;
    }
}
