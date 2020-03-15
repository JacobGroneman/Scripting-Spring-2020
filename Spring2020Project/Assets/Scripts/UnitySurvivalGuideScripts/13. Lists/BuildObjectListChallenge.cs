using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEditor;
using UnityEditor.Build.Content;
using UnityEngine;

//Challenge: Create a List/array of 3 gameobjects. Randomly Spawn them with a random position on the screen
//Between -10 & +10 on the X/Y when you hit the Space Key. Every object spawned is stored into a list called
//Objects Created. After 10 spawned objects, disable the spacebar spawn and turn the objects green.
//Then clear the list.

public class BuildObjectListChallenge : MonoBehaviour
{
    public int SpawnCount {get; set;}
    
    public bool _colorChange;
    
    public List<GameObject> objectsToSpawn;
    public List<GameObject> objectsCreated;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (SpawnCount == 10)
            {
                _colorChange = true;
                return;
            }
            
            SpawnObj();
            SpawnCount++;
        }

        if (_colorChange == true)
        {
            _colorChange = false;
            foreach (var obj in objectsCreated)
            {
                obj.GetComponent<MeshRenderer>().material.color = Color.green;
            }
            objectsCreated.Clear();
        }
    }
    
    public void SpawnObj()
    {
        GameObject objectSpawned = objectsToSpawn[Random.Range(0, objectsToSpawn.Count)];
       
       var realGameObject = Instantiate(objectSpawned, 
            new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), 0), 
            Quaternion.identity) as GameObject;
        objectsCreated.Add(realGameObject);
    }
}
