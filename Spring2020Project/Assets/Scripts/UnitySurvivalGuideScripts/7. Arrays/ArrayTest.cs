using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using UnityEngine;

public class ArrayTest : MonoBehaviour
{
    public string[] names = new string[] {"Gill", "Bill", "Jill", "Phil", "Cecil"};
    public int[] age = new int[]{5, 10, 15, 20, 37};
    public string[] car = new string[]{"Bolt", "Dart", "Cruise", "Focus", "Fiesta"};
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            UnityEngine.Debug.Log(names[4] +" "+ age[4] +" "+ car[4]);
        }
    }
}
