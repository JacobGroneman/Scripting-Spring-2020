using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject sparks;
    private GameObject[] spawners;
    
    // Start is called before the first frame update
    void Start()
    {
        spawners = GameObject.FindGameObjectsWithTag("Spawn");
        InvokeRepeating("Spawn", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        GameObject spawn = spawners[Random.Range(0, spawners.Length)];
        Instantiate(sparks, spawn.transform.position, Quaternion.identity);
    }
}
