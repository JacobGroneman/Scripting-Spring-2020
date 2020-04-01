using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastPractice : MonoBehaviour
{
    public float targetDistance;
    
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit));
        {
            targetDistance = hit.distance;
        }
    }
}
