using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = System.Diagnostics.Debug;

public class Bullet : MonoBehaviour
{
   public float speed = 20;
   public int damageAmount = 30;
   public Rigidbody2D rb;
   public GameObject impactEffect;
   
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        
        if (enemy != null)
        {
            enemy.TakeDamage(damageAmount); 
        }

        Instantiate(impactEffect, transform.position, transform.rotation);
        
        UnityEngine.Debug.Log(hitInfo.name);
        
        Destroy(gameObject);
    }
}
