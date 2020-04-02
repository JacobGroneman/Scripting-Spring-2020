using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopPractice : MonoBehaviour
{
    public GameObject[] colorObjs;
    
    void Start()
    { 
        GameObject[] objs = GameObject.FindGameObjectsWithTag("ObjectsToPaint");
        
        foreach (var obj in objs)
        {
            obj.transform.position = 
                new Vector3(Random.Range(1, 10), Random.Range(1, 10), Random.Range(1, 10));
        }
        
        objs = colorObjs;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //ColorObjects(colorObjs);
        }
    }

    /*IEnumerator ColorObjects(GameObject[] objectsNeededToPaint)
    {
        for (int i = 0; i < objectsNeededToPaint.Length; i++)
        {
            objectsNeededToPaint[Random.Range(0, objectsNeededToPaint.Length)].
                    GetComponent<MeshRenderer>().material.color 
                = new Color(Random.value, Random.value, Random.value);
        }
        yield return new WaitForSeconds(1);
    }*/
}

