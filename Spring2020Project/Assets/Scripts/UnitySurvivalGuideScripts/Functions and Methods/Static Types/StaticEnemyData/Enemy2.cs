using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;


public class Enemy2 : MonoBehaviour
{
   private UIManager _ui;
   
   private void OnEnable()
   {
      SpawnManager.EnemyCount++;
      _ui = GameObject.Find("UserInterface").GetComponent<UIManager>();
      _ui.UpdateEnemyCount();
      Die();
   }
   private void OnDisable()
   {
      SpawnManager.EnemyCount--;
   }

   void Die()
   {
      Destroy(this.gameObject, UnityEngine.Random.Range(2, 6));
      _ui.UpdateEnemyCount();
   }
}
