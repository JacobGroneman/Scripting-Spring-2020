using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerp : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth = 100;

    public HealthBarp healthBar;
    
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        #region Inputs
            
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            GetHealth(10);
        }
        
        #endregion

        #region MaxMinHealthLogic
        
        if (currentHealth <= 0)
        {
            currentHealth = 0;
        }
        else if (currentHealth >= maxHealth)
        {
            currentHealth = maxHealth;
        }
        
        #endregion
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    void GetHealth(int healthPoints)
    {
        currentHealth += healthPoints;
        healthBar.SetHealth(currentHealth);
    }
}
