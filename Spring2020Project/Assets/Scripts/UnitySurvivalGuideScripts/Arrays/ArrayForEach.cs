using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.AssetImporters;
using UnityEngine;

public class ArrayForEach : MonoBehaviour
{
    public string[] itemName = new string[]{"A", "B", "C", "D", "E", "F", "G", "H", "I", "J"};
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space));
        {
            foreach (var letter in itemName) 
            {
                UnityEngine.Debug.Log(letter);
                
                if (letter == "A");
                {
                    UnityEngine.Debug.Log(letter);
                }
            }
        }
    }
}
