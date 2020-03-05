using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class ReturnParameterDelegate : MonoBehaviour
{
    public Func<int, int, int> onCalculateSum;
    void Start()
    {
        onCalculateSum = (a, b) => a + b;
       var total = onCalculateSum?.Invoke(5, 42);
       Debug.Log(name + "'s Total: " + total);
    }
}
