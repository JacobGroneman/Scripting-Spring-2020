using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject sparks;
    private GameObject[] spawners;
    private List<GameObject> UFOs;
    
    // Start is called before the first frame update
    void Start()
    {
        spawners = GameObject.FindGameObjectsWithTag("Spawn");
        InvokeRepeating("Spawn", 1, 1);
        UFOs = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        GameObject spawn = spawners[Random.Range(0, spawners.Length)];
        GameObject clone = Instantiate(sparks, spawn.transform.position, Quaternion.identity) as GameObject;
        clone.name = "UFO - " + Time.time.ToString();
        UFOs.Add(clone);
    }
}
