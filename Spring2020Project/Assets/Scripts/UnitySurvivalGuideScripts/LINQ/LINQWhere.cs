using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class LINQWhere : MonoBehaviour
{
    public string[] names = 
    {"Jessie", "Ryan", "Batista", "James", "Karen", 
        "Richard", "Christian", "Randy", "Hannah", "Jill"};

    private void Start()
    {
       var result =  names.Where(n => n.Length > 5);
       
       foreach (var name in result)
       {
           Debug.Log(name);   
       }
    }
}
