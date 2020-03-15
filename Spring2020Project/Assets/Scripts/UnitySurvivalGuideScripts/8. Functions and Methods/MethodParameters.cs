using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodParameters : MonoBehaviour
{
    public int health = 25;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            DamageAmount(5);
        }
    }
    
    
    private void DamageAmount(int damage)
    {
        health -= damage;
        
        if (health <= 1)
        {
            health = 0;
            Destroy(this.gameObject);
        }
    }
    
}
