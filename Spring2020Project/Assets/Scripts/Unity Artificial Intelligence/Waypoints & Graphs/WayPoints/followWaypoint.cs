using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class followWaypoint : MonoBehaviour
{
    public GameObject[] waypoints;
    private int _currentWaypoint = 0;
    public float velocity = 10.0f;
    public float rotationSpeed = 1f;
        
    void Start()
    {
        
    }

    void Update()
    {
        if (Vector3.Distance(this.transform.position, waypoints[_currentWaypoint].transform.position) < 3)
        {
            _currentWaypoint++;
        }
        if (_currentWaypoint >=  waypoints.Length)
        {
            _currentWaypoint = 0;
        }

        
        //this.transform.LookAt(waypoints[_currentWaypoint].transform);
        
        Quaternion lookAtWaypoint = Quaternion.LookRotation(
                waypoints[_currentWaypoint].transform.position - this.transform.position);
        
        this.transform.rotation = Quaternion.Slerp(
            this.transform.rotation, lookAtWaypoint, rotationSpeed * Time.deltaTime);
        
        this.transform.Translate(0, 0, velocity * Time.deltaTime);
    }
}
