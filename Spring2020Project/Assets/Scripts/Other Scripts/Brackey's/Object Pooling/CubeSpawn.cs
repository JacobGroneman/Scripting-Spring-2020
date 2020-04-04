using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawn : MonoBehaviour
{
    public GameObject cubePrefabToSpawn;
    
    void FixedUpdate()
    {
        Instantiate(cubePrefabToSpawn, transform.position, Quaternion.identity);
    }
}
