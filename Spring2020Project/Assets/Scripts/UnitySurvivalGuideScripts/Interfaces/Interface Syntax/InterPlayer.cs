using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterPlayer : MonoBehaviour, IDamagable, IShootable
{
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }

    public int Health { get; set; }
    
    public void Damage(int damageAmount)
    {
       GetComponent<MeshRenderer>().material.color = Color.red;
    }

    public void Shoot()
    {
        
    }
}
