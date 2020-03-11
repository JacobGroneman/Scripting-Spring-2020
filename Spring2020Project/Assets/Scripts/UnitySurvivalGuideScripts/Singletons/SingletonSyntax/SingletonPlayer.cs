using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonPlayer : MonoBehaviour
{
   private void Start()
   {
      SingletonGameManager.Instance.DisplayName();
      SingletonUIManager.Instance.UpdateScore(40);
      SingletonSpawnManager.Instance.StartSpawn();
      MonoLevelManager.Instance.LoadLevel();
   }
}
