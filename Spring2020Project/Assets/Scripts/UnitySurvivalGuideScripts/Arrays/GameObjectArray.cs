using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectArray : MonoBehaviour
{
    
    public GameObject[] objects;

    void Update()
    {
        //For Each Loop
        if (Input.GetKeyDown(KeyCode.Space));
        {
            foreach (var item in objects)
            {
                item.GetComponent<MeshRenderer>().material.color = Color.red;
            }
        }
        //For Loop
        /*if (Input.GetKeyDown(KeyCode.Space));
        {
            for (int i = 0; i < objects.Length; i++)
            {
                objects[i].GetComponent<MeshRenderer>().material.color = Color.red;
            }
        }*/
    }
}
