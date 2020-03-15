using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = System.Diagnostics.Debug;

public class Aim : MonoBehaviour
{
    [SerializeField]
    private Transform _sphere;
    
    void Start()
    {
        
    }

    void Update()
    {
       Vector3 directionToFace = _sphere.position - transform.position;
       UnityEngine.Debug.DrawRay(transform.position, directionToFace, Color.magenta);
       transform.rotation = Quaternion.LookRotation(directionToFace);
    }
}
