﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bHbPlayer : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public bHbHealthBar healthBar;

    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
        }

        void TakeDamage(int damage)
        {
            currentHealth -= damage;
            healthBar.SetHealth(currentHealth);
        }
    }
}
