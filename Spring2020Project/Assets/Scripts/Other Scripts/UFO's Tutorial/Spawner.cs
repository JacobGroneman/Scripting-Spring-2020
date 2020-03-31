using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject sparks;
    public int myInt = 5;
    public MyController myController;
    private GameObject[] spawners;
    private List<GameObject> UFOs;
    
    
    // Start is called before the first frame update
    void Start()
    {
        spawners = GameObject.FindGameObjectsWithTag("Spawn");
        InvokeRepeating("Spawn", 1, 1);
        UFOs = new List<GameObject>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            foreach (GameObject ufo in UFOs)
            {
                Instantiate(sparks, ufo.transform.position, Quaternion.identity);
                Destroy(ufo);
            }
        }
    }
    
    void Spawn()
    {
        GameObject spawn = spawners[Random.Range(0, spawners.Length)];
        GameObject clone = Instantiate(sparks, spawn.transform.position, Quaternion.identity) as GameObject;
        clone.name = "UFO - " + Time.time.ToString();
        UFOs.Add(clone);
        UFOController controller = clone.GetComponent<UFOController>();
        controller.myController = myController;
    }
}