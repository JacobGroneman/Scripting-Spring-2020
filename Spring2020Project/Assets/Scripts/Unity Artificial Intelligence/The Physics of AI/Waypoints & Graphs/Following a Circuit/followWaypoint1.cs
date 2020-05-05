using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class followWaypoint1 : MonoBehaviour
{
    public float velocity = 10.0f;
    public float rotationSpeed = 1.0f;
    
    public GameObject[] waypoints;
    private int _currentWaypoint = 0;
    
    public GameObject tracker;
    public float trackerVelocity = 12.0f;
    public float trackerLookAhead = 10.0f;

    void Start()
    {
        tracker = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        tracker.GetComponent<MeshRenderer>().enabled = false;
        Destroy(tracker.GetComponent<Collider>());
        tracker.transform.position = this.transform.position;
        tracker.transform.rotation = this.transform.rotation;
    }

    void Update()
    {
        ProgressTracker();
        
        Quaternion lookAtWaypoint = Quaternion.LookRotation(
                tracker.transform.position - this.transform.position);
        
        this.transform.rotation = Quaternion.Slerp(
            this.transform.rotation, lookAtWaypoint, rotationSpeed * Time.deltaTime);
        
        this.transform.Translate(0, 0, velocity * Time.deltaTime);
    }

    void ProgressTracker()
    {
        if (Vector3.Distance(tracker.transform.position, this.transform.position) > trackerLookAhead)
            return;
        
        if (Vector3.Distance(tracker.transform.position, waypoints[_currentWaypoint].transform.position) < 3)
        {
            _currentWaypoint++;
        }
        if (_currentWaypoint >=  waypoints.Length)
        {
            _currentWaypoint = 0;
        }
        
        tracker.transform.LookAt(waypoints[_currentWaypoint].transform);
        tracker.transform.Translate(0, 0, trackerVelocity * Time.deltaTime);
    }
}
