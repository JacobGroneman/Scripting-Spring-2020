using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = System.Diagnostics.Debug;

public class Bullet : MonoBehaviour
{
   public float speed = 20;
   public Rigidbody2D rb;
   
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        UnityEngine.Debug.Log(hitInfo.name);
        Destroy(gameObject);
    }
}
