using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShoot : MonoBehaviour
{
    public GameObject shellPrefab, shellSpawnPosition;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }

    void Fire()
    {
        GameObject shell =
            Instantiate(shellPrefab, shellSpawnPosition.transform.position, 
                shellSpawnPosition.transform.rotation);
    }
}
