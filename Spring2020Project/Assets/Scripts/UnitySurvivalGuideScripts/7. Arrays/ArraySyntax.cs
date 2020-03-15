using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = System.Diagnostics.Debug;

public class ArraySyntax : MonoBehaviour
{
    public string[] names;
    public int[] values = new int[6];
    public float[] percentages = new float[]{5.3f, 2.2f, 35.6f, 45.2f};

    public void Start()
    {
        UnityEngine.Debug.Log(names[2]);
        UnityEngine.Debug.Log(values[3]);
        UnityEngine.Debug.Log(percentages[2]);
    }
}
