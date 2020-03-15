using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class ArrayRandomTest : MonoBehaviour
{
    public int selectionNumber;
    public string[] names = new string[] {"Gill", "Bill", "Jill", "Phil", "Cecil"};
    public int[] age = new int[]{5, 10, 15, 20, 37};
    public string[] car = new string[]{"Bolt", "Dart", "Cruise", "Focus", "Fiesta"};

     void Start()
     { 
         
     }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            selectionNumber = UnityEngine.Random.Range(0, names.Length);
            UnityEngine.Debug.Log(selectionNumber);
            UnityEngine.Debug.Log(names[selectionNumber] +" "+ age[selectionNumber] +" "+ car[selectionNumber]);
        }
        
    }

    
}
