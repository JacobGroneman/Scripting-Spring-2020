﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMove : MonoBehaviour
{
    public Vector3 goal = new Vector3(5, 0, 4);
    public float speed = 0.1f;
    
    void LateUpdate()
    {
        this.transform.Translate(goal.normalized * speed * Time.deltaTime);
    }
}
