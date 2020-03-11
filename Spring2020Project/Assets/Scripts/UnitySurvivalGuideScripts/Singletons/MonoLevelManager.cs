using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Debug = System.Diagnostics.Debug;

public class MonoLevelManager : MonoSingleton<MonoLevelManager>
{
   public override void Init()
   {
      base.Init();
   }

   public void LoadLevel()
   {
      //SceneManager.LoadScene()
      UnityEngine.Debug.Log("Level Loaded");
   }
}
