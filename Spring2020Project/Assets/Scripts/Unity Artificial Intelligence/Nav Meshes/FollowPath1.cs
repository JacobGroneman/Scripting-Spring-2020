using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.AI;

public class FollowPath1 : MonoBehaviour
{
    public GameObject waypointManager;
    private GameObject[] _waypoints;

    public NavMeshAgent navMeshAgent;
    
    void Start()
    {
        _waypoints = waypointManager.GetComponent<WaypointManager>().waypoints;
        navMeshAgent = this.GetComponent<NavMeshAgent>();
    }
    
    public void GoToHeliPad()
    {
        navMeshAgent.SetDestination(_waypoints[4].transform.position);
    }

    public void GoToRuin()
    {
        navMeshAgent.SetDestination(_waypoints[0].transform.position);
    }
    
    public void GoToTank()
    {
        navMeshAgent.SetDestination(_waypoints[8].transform.position);
    }
}
