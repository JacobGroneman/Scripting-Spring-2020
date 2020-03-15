using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionUIManager : MonoBehaviour
{
   private void OnEnable()
   {
      ActionPlayer.onDamageReceived += UpdateHealthUI;
   }

   void UpdateHealthUI(int health)
   {
      UnityEngine.Debug.Log("Health: " + health);
   }
}
