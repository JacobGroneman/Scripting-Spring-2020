using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = System.Diagnostics.Debug;

public class ArrayForEachMyOwn : MonoBehaviour
{
    public bool itemExists;

    public string[] items = new string[]
        {"Ax", "Sword", "Gravel", "Door", "Ender Pearl", "Gold Ingot", "Wood Block", "Bow", "Arrow", "Bed"};

    public GameObject[] itemObjects;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2));
        {
            foreach (var item in items)
            {
                if (item == "Gold Ingot")
                {
                    UnityEngine.Debug.Log("The Following Item Exists: " + item + "." + " Instantiate? Y/N");
                
                    itemExists = true;

                    if (Input.GetKeyDown(KeyCode.Y));
                    {
                        Instantiate(itemObjects[6], transform.forward, Quaternion.identity);
                        UnityEngine.Debug.Log("Item Instantiated");
                    }
                }
            }
        }
    }
}
