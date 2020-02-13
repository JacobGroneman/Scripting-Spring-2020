using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemy;
    public static int EnemyCount;
         void Start()
         {
             
         }
         
         void Update()
         {
             if (Input.GetKeyDown(KeyCode.Space))
             {
                 Instantiate(enemy);
             }
         }
}
