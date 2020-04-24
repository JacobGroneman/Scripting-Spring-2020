using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorGetSet : MonoBehaviour
{
    public GameObject obj;

    public bool IsObjAffected
    {
        get => IsObjAffected;
        set
        {
            if (value == true)
            {
                Debug.Log(obj.name + " is affected.");
                obj.GetComponent<MeshRenderer>().material.color = Color.green;
            }
        }
    }
    
    void Start()
    {
        obj.GetComponent<MeshRenderer>().material.color = Color.white;
        IsObjAffected = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (IsObjAffected == false)
            {
                IsObjAffected = true;
            }
        }
    }
}
