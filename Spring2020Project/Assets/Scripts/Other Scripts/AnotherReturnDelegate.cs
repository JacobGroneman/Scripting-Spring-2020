using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using Debug = System.Diagnostics.Debug;

public class AnotherReturnDelegate : MonoBehaviour
{
    public GameObject obj;
    public Func<float, float, float, float> onCalculateAverageDistanceFromOrigin;
    
    void Start()
    {
        onCalculateAverageDistanceFromOrigin = (a, b, c) => a + b + c / 3;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            var position = obj.transform.position;
            var average = onCalculateAverageDistanceFromOrigin?.Invoke(position.x, position.y, position.z);
            UnityEngine.Debug.Log("Object's Position Average: " + average);
        }
    }
}
