using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = System.Diagnostics.Debug;

public class SpawnPeaker : MonoBehaviour
{
    public Spawner MySpawner;
   
    void Start()
    {
        UnityEngine.Debug.Log(MySpawner.myInt);
    }

    
    void Update()
    {
        
    }
}
