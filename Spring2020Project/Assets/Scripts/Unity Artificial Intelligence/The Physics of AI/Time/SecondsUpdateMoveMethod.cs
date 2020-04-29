using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondsUpdateMoveMethod : MonoBehaviour
{
    //(Basically Time.DeltaTime)
    
    private float _timeStartOffset = 0;
    private bool _getStartTime = false;
    
    void Update()
    {
        if (!_getStartTime)
        {
            _timeStartOffset = Time.realtimeSinceStartup;
            _getStartTime = true;
        }
        
        this.transform.position = 
            new Vector3(this.transform.position.x, this.transform.position.y,
                Time.realtimeSinceStartup - _timeStartOffset);
    }
}
