using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class ReturnDelegatePractice : MonoBehaviour
{
    public GameObject gO1, gO2;

    public Func<GameObject, GameObject, float> onCalculateAverageScale;
    void Start()
    {
        onCalculateAverageScale = (a, b) => (
            (a.transform.lossyScale.x * a.transform.lossyScale.y * a.transform.lossyScale.z) +
            (b.transform.lossyScale.x * b.transform.lossyScale.y * b.transform.lossyScale.z) /2 );
        
       var total = onCalculateAverageScale?.Invoke(gO1, gO2);
       
       Debug.Log("The scale average of " + gO1.name + " and " + gO2.name + " is: " + total);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            DestroySmallestGameObject();
        }
    }

    void DestroySmallestGameObject()
    {
        float gO1Volume = gO1.transform.lossyScale.x * gO1.transform.lossyScale.y * gO1.transform.lossyScale.z;
        float gO2Volume = gO2.transform.lossyScale.x * gO2.transform.lossyScale.y * gO2.transform.lossyScale.z;
        
        if (gO1Volume >= gO2Volume)
        {
            Destroy(gO2);
        }
        else if (gO1Volume <= gO2Volume)
        {
            Destroy(gO1);
        }
    }
}
