using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformPositions : MonoBehaviour
{
    
    void Start()
    {
        /* Option #1
        transform.position = new Vector3(0, 0, 0); */
        /* Option #2
        StartPositionZero(); */
        /* Option #3
        StartPositionZeroInput(Vector3.zero);; */
        /* Option #4
        transform.Position = GetPosition(); */
        /* Option #5
        transform.Position = GetPos(0, 0, 0); */
    }

    
    void Update()
    {
        
    }

    void StartPositionZero()
    {
        transform.position = Vector3.zero;
    }

    void StartPositionZeroInput(Vector3 position)
    {
        transform.position = position;
    }

    private Vector3 GetPosition()
    {
        return Vector3.zero;
    }

    private Vector3 GetPos(int x, int y, int z)
    {
        Vector3 pos = new Vector3(x, y, z);
        return pos;
    }
}
