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
        if (waypoints.Length > 0)
        {
            foreach (var waypoint in waypoints)
            {
                graph.AddNode(waypoint);
            }

            foreach (var link in links)
            {
                graph.AddEdge(link.node1, link.node2);
                if (link.dir == Link.direction.BI)
                    graph.AddEdge(link.node2, link.node1);
            }
        }
    }

    void Update()
    {
        graph.debugDraw();
    }
}
