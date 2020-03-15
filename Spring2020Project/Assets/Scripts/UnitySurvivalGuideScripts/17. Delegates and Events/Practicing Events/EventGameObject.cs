using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Color = System.Drawing.Color;

public class EventGameObject : MonoBehaviour
{
    
    void Start()
    {
        EventCamera.onColorChange += TurnColor;
    }

    private void OnDisable()
    {
        EventCamera.onColorChange -= TurnColor;
    }

    void TurnColor(UnityEngine.Color theColor)
    {
        this.GetComponent<MeshRenderer>().material.color = theColor;
    }
}
