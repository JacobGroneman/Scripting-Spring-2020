using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListSyntax : MonoBehaviour
{
    public List<int> amounts;
    public List<GameObject> stuff;
    
    void Start()
    {
        amounts.Capacity = 9;
        amounts.Add( 6);

        if (amounts.Contains(6))
        {
            amounts.Clear();
        }
        
        stuff.Sort();
       stuff.Add(gameObject);
       stuff[0] = GameObject.Find("Player");

    }
}
