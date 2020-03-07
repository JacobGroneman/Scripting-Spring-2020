using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class LINQDistinct : MonoBehaviour
{
    public string[] names =
    {
        "Kyle", "Dave", "Winston", "Paula",
        "Ryan", "Dave", "Paula", "Dan", "John", "Ryan"
    };

    private void Start()
    {
        var uniqueNames = names.Distinct();
        Debug.Log("Names: " + uniqueNames);
    }
}
