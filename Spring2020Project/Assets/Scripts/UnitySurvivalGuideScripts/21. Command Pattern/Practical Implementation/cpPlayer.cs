using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cpPlayer : MonoBehaviour
{
    private cpICommand _up, _down, _left, _right;
    [SerializeField]
    private float speed = 2.0f;
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _up = new cpCmdUp(this.transform, speed);
            _up.Execute();
        }
        
        else if (Input.GetKey(KeyCode.S))
        {
            _down = new cpCmdDown(this.transform, speed);
            _down.Execute();
        }
        
        else if (Input.GetKey(KeyCode.A))
        {
            _left = new cpCmdLeft(this.transform, speed);
            _left.Execute();
        }
        
        else if (Input.GetKey(KeyCode.D))
        {
            _right = new cpCmdRight(this.transform, speed);
            _right.Execute();
        }
    }
}
