using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColorReturn : MonoBehaviour
{
    public GameObject[] objectsToColor;
    
    void Start()
    {
        objectsToColor = ColorTheObjects();
    }

    GameObject[] ColorTheObjects()
    {
        GameObject[] colorArray = GameObject.FindGameObjectsWithTag("Player");

        foreach (var obj in colorArray)
        {
            obj.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
        }
        
        return colorArray;
    }
}
