using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodSyntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.Debug.Log("Start MyMethod");
        MyMethod();
        UnityEngine.Debug.Log("MyMethod Completed");
    }

    public void MyMethod()
    {
        UnityEngine.Debug.Log("MyMethod");
    }
}
