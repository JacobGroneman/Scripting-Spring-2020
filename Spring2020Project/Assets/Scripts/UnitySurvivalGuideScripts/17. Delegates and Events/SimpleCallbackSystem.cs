using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class SimpleCallbackSystem : MonoBehaviour
{
    
    void Start()
    {
        StartCoroutine(taskOne(() => Debug.Log("Task Complete!")));
    }

    private IEnumerator taskOne(Action onTaskComplete = null)
    {
       yield return new WaitForSeconds(5);
       onTaskComplete?.Invoke();
    }
}
