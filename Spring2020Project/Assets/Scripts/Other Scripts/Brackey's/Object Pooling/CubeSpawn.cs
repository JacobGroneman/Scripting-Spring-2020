using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawn : MonoBehaviour
{
    private BrackeysPoolManager _poolManager;
    
    private void Start()
    {
        _poolManager = BrackeysPoolManager.Instance;
    }

    void FixedUpdate()
    {
        BrackeysPoolManager.Instance.SpawnFromPool("Cube", transform.position, Quaternion.identity);
    }
}
