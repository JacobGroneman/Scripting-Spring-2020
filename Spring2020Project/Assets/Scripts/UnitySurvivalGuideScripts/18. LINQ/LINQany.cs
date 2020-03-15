using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LINQany : MonoBehaviour
{
    public string[] names = {"Agatha", "Belinda", "Claudell", "Dingus", "Emelita", "Fifo"};
    void Start()
    {
        var nameFound = names.Any((name) => name == "Emelita");
        Debug.Log("Name Found: " + nameFound);
    }
}
