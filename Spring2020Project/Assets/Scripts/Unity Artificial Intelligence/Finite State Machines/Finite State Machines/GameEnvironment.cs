using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public sealed class GameEnvironment : MonoBehaviour
{
    private static GameEnvironment instance;
    private List<GameObject> _checkpoints = new List<GameObject>();
    public List<GameObject> Checkpoints {get { return _checkpoints;}}

    public static GameEnvironment Singleton
    {
        get
        {
            if ( instance == null)
            {
                instance = new GameEnvironment();
                instance.Checkpoints.AddRange(GameObject.FindGameObjectsWithTag("Checkpoint"));

                //Alphabetical Order Checkpoints
                instance._checkpoints = instance._checkpoints.OrderBy(waypoint => waypoint.name).ToList();
            }
            return instance;
        }
    }
}
