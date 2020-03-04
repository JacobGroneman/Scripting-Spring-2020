using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = System.Diagnostics.Debug;

public class LambdaOperator : MonoBehaviour
{
    public Func<string, int> NumberCount;
    
    void Start()
    {
        NumberCount = (word) => word.Length;
        int countResult = NumberCount("Boodgalooga");
        UnityEngine.Debug.Log("Number of Letters: " + countResult);
    }

    
    void Update()
    {
        
    }
}
