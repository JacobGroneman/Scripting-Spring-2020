using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopPractice : MonoBehaviour
{ 
    void Start()
    { 
        GameObject[] objs = GameObject.FindGameObjectsWithTag("ObjectsToColor");
        
        foreach (var obj in objs)
        {
            obj.transform.position = 
                new Vector3(Random.Range(1, 10), Random.Range(1, 10), Random.Range(1, 10));
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //ColorObjects();
        }
    }

    /*IEnumerator ColorObjects()
    {
        for (int i = 0; i < objs.Length; i++)
        {
            colorObjs[Random.Range(0, colorObjs.Length)].
                    GetComponent<MeshRenderer>().material.color 
                = new Color(Random.value, Random.value, Random.value);
        }
        yield return new WaitForSeconds(1);
    }*/
}

