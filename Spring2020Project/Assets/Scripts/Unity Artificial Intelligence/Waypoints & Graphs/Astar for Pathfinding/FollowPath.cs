using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class FollowPath : MonoBehaviour
{
    private Transform _goal;
    private float _velocity = 5.0f;
    private float _accuracy = 1.0f;
    private float _rotationalVelocity = 2.0f;
    public GameObject waypointManager;
    private GameObject[] _waypoints;
    private GameObject _currentNode;
    private int currentWaypoint = 0;
    private Graph _graph;

    void Start()
    {
        _waypoints = waypointManager.GetComponent<WaypointManager>().waypoints;
        _graph = waypointManager.GetComponent<WaypointManager>().graph;
        _currentNode = _waypoints[0];
    }

    void LateUpdate()
    {
        if (_graph.getPathLength() == 0 || currentWaypoint == _graph.getPathLength())
            return;

        //Closest Current WayPoint
        _currentNode = _graph.getPathPoint(currentWaypoint);

        //If close to Current WayPoint, Move to Next WayPoint
        if (Vector3.Distance(
                _graph.getPathPoint(currentWaypoint).transform.position, 
                this.transform.position) < _accuracy)
        {
            currentWaypoint++;
        }
        
        //If Path Isn't Completed
        if (currentWaypoint < _graph.getPathLength())
        {
            _goal = _graph.getPathPoint(currentWaypoint).transform;
            Vector3 _lookAtGoal = new Vector3(
                _goal.position.x, this.transform.position.y, _goal.position.z);
            Vector3 _direction = _lookAtGoal - this.transform.position;

            this.transform.rotation = Quaternion.Slerp(this.transform.rotation,
                Quaternion.LookRotation(_direction), Time.deltaTime * _rotationalVelocity);
        }
    }

    public void GoToHeliPad()
    {
        _graph.AStar(_currentNode, _waypoints[4]);
        currentWaypoint = 0;
    }

    public void GoToRuin()
    {
        _graph.AStar(_currentNode, _waypoints[0]);
        currentWaypoint = 0;
    }
    
    public void GoToTank()
    {
        _graph.AStar(_currentNode, _waypoints[8]);
        currentWaypoint = 0;
    }
}
