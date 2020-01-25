using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoop : MonoBehaviour
{

    private string _theStereotypicalQuestion = "Are we there yet?" ;
    
    void Start()
    {
        for (int totalDistance = 0; totalDistance < 100; totalDistance++)
        {
            UnityEngine.Debug.Log(_theStereotypicalQuestion);
        }
        UnityEngine.Debug.Log("WE HAVE ARRIVED, NOW SHUT-UP!!");
    }

   
    void Update()
    {
        
    }
}
