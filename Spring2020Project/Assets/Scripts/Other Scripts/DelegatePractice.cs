using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegatePractice : MonoBehaviour
{
    public GameObject obj1, obj2, obj3;
    
    public delegate void ReturnOriginalStates();
    public ReturnOriginalStates returnOriginalStates;
    
    void Start()
    {
        InitializeOriginDelegate();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            returnOriginalStates?.Invoke();
        }
    }

    void VectorsToOrigins()
    {
        obj1.transform.position = new Vector3(0, 1, 2);
        obj2.transform.position = new Vector3(5, 2, 4);
        obj3.transform.position = new Vector3(10, 3, 6);
    }

    void ColorsToOrigins()
    {
        obj1.GetComponent<MeshRenderer>().material.color = Color.red;
        obj2.GetComponent<MeshRenderer>().material.color = Color.blue;
        obj3.GetComponent<MeshRenderer>().material.color = Color.yellow;
    }

    void EnableColliders()
    {
        //Find a better Way to write this.
        obj1.GetComponent<BoxCollider>().enabled = true;
        obj2.GetComponent<BoxCollider>().enabled = true;
        obj3.GetComponent<BoxCollider>().enabled = true;
    }
    

    void InitializeOriginDelegate()
    {
        returnOriginalStates += VectorsToOrigins;
        returnOriginalStates += ColorsToOrigins;
        returnOriginalStates += EnableColliders;
    }
    
}
