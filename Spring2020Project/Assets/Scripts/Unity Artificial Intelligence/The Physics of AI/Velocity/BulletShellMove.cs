using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShellMove : MonoBehaviour
{
    private float _speed;
    
    void Update()
    { 
        //(Time.DeltaTime = 1 meter/second)
        
        //this.transform.Translate(0, 0,  _speed * Time.deltaTime);
        
        //this.transform.Translate(0, _speed * Time.deltaTime, _speed * Time.deltaTime);
        
        var realTime = _speed * Time.deltaTime;
        
        this.transform.Translate(realTime, realTime, realTime);
    }
}
