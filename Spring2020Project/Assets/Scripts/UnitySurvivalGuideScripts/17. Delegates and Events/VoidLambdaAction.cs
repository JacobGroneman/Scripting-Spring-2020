using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class VoidLambdaAction : MonoBehaviour
{
    public Action<int, int> Sum;

    void Start()
    {
        Sum = (a, b) =>
        {
            var total = a + b;

            UnityEngine.Debug.Log(total);

            if (total < 100)
            {
                UnityEngine.Debug.Log("Total is less then 100");
            }
            else
            {
                UnityEngine.Debug.Log("Total is more then 100");
            }
        };
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RandomSum();
        }
    }

    void RandomSum()
    {
        Sum?.Invoke(Random.Range(1, 100), Random.Range(1, 100));
    }
    
}
