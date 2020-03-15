using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionArrayMethod : MonoBehaviour
{
    public Vector3[] positions;
    private int _randomIndex;
    void Start()
    {
        _randomIndex = GetRandom();
        UnityEngine.Debug.Log("Random Index: " + _randomIndex);
        transform.position = GetPosition(_randomIndex);
    }
    private int GetRandom()
    {
        return Random.Range(0, positions.Length);
    }

    private Vector3 GetPosition(int index)
    {
        return positions[index];
    }
}
