using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayLogic : MonoBehaviour
{
    public int[] itemID = new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
    public string[] items = new string[]{"shovel", "ax", "Sword", "Shield", "Mace", "Arrow", "Saber", "Wand", "ChinaStar", "Rock"};

    void Start()
    {
        
    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            for (int i = 0; i < itemID.Length; i++)
            {
                if (items[i] == "Sword");
                {
                    UnityEngine.Debug.Log("Item Found!");
                    UnityEngine.Debug.Log("Number is: " + itemID[i]);
                }
            }
        }
    }
}
