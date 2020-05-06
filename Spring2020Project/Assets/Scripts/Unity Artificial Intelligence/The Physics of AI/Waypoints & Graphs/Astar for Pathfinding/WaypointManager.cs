using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Link
{
    public enum direction {UNI, BI};
    public GameObject node1, node2;
    public direction dir;
}

public class WaypointManager : MonoBehaviour
{
    public GameObject[] waypoints;
    public Link[] links;
    public Graph graph = new Graph();

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
