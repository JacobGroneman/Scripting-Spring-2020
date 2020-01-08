using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = System.Diagnostics.Debug;

public class MyController : MonoBehaviour
{
    private static MyController myController;

    public static MyController Instance()
    {
        if (!myController)
        {
            myController = FindObjectOfType(typeof(MyController)) as MyController;
            if (!myController)
            {
                UnityEngine.Debug.LogError("There needs to be one active MyController script" +
                                           "on a GameObject in your scene");
            }
        }

        return myController;
    }

    public void FoundMe()
    {
        UnityEngine.Debug.Log("Found Me");
    }
    
}
