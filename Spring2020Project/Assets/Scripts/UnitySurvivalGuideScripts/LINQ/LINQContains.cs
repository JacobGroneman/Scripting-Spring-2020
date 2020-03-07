using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LINQContains : MonoBehaviour
{
    public string[] names = {"Agatha", "Belinda", "Claudell", "Dingus", "Emelita", "Fifo"};
    void Start()
    {
        var nameFound = names.Contains("Agatha");
        Debug.Log("Name Found: " + nameFound);
    }
}
