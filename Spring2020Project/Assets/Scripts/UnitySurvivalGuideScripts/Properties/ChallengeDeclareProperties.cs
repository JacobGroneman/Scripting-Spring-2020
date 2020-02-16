using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = System.Diagnostics.Debug;

public class ChallengeDeclareProperties : MonoBehaviour
{
    private int Speed {get; set;}
    public string name;

    public string Name
    {
        get => name;
        set
        {
            name = value;
            UnityEngine.Debug.Log("Name Is Set");
        }
    }

    void Start()
    {
        name = "Bill";
        Speed = 3;
    }
}
