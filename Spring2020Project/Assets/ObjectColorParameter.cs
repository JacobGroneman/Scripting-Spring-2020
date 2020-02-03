using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectColorParameter : MonoBehaviour
{
    public GameObject chameleon;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ColorChange(chameleon, Color.red);
        }
    }

    void ColorChange(GameObject obj, Color colorToAssign)
    {
        obj.GetComponent<MeshRenderer>().material.color = colorToAssign;
    }
}
