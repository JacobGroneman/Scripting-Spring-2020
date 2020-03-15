using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = System.Diagnostics.Debug;

public class DoWhileLoop : MonoBehaviour
{

    public int gumballs = 100;
    
    void Start()
    {
        StartCoroutine(GumballDispenser());
    }

    
    void Update()
    {
        
    }

    IEnumerator GumballDispenser()
    {
        do
        {
            UnityEngine.Debug.Log("There are " + gumballs + " gumballs.");
            gumballs--;
            yield return new WaitForSeconds(.5f);
        } while (gumballs > 0);
    }
}

