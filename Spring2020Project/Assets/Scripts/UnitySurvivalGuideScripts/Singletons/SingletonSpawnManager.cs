using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonSpawnManager : MonoBehaviour
{
    private static SingletonSpawnManager _instance;

    public static SingletonSpawnManager Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.LogError("Spawn Manager is NULL");
            }

            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }

    public void StartSpawn()
    {
        Instantiate(GameObject.Find("Enemy"), Vector3.zero, Quaternion.identity);
    }
}
