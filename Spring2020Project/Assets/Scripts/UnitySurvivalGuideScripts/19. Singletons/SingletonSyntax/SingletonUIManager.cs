using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonUIManager : MonoBehaviour
{
   private static SingletonUIManager _instance;

   public static SingletonUIManager Instance
   {
      get
      {
         if (_instance == null)
         {
            Debug.LogError("UI Manager is NULL");
         }

         return _instance;
      }
   }

   private void Awake()
   {
      _instance = this;
   }

   public void UpdateScore(int score)
   {
      Debug.Log("Score: " + score);
      Debug.Log("Notifying Game Manager");
      SingletonGameManager.Instance.DisplayName();
   }
}
