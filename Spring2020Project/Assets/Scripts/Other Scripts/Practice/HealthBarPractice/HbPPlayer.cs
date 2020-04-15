using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HbPPlayer : MonoBehaviour
{
   public int maxHealth = 100;
   public int currentHealth;

   public HealthBar healthBar;
   
   void Start()
   {
      currentHealth = maxHealth;
      healthBar.slider.maxValue = maxHealth;
   }

   void Update()
   {
      if (currentHealth <= 0)
      {
         currentHealth = 0;
      }
      else if (currentHealth >= maxHealth)
      {
         currentHealth = maxHealth;
      }
   }

   public void ReceiveDamage(int damage)
   {
      currentHealth -= damage;
      healthBar.SetCurrentHealth(currentHealth);
   }

   public void ReceiveHealth(int health)
   {
      currentHealth += health;
      healthBar.SetCurrentHealth(currentHealth);
   }
}


