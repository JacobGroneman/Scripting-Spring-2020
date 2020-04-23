using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMoveToGoal : MonoBehaviour
{
    public float speed = 2.0f;
    public float goalAccuracy = 0.01f;
    public Transform goal;
    
    void LateUpdate()
    {
        this.transform.LookAt(goal.position);
        
        Vector3 direction = goal.position - this.transform.position;

        Debug.DrawRay(this.transform.position, direction, Color.magenta);

        if (direction.magnitude > goalAccuracy)
        {
            this.transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
        }
    }
}
