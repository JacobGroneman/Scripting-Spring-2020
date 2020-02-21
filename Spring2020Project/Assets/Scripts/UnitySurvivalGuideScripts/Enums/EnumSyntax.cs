using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumSyntax : MonoBehaviour
{
   public enum LevelSelector
   {
       Easy,
       Medium,
       Hard,
       Expert
   }

   public LevelSelector currentLevel;
   
    void Start()
    {
        switch (currentLevel)
        {
            case LevelSelector.Easy:
                UnityEngine.Debug.Log("Current Level is Easy");
                break;
            case LevelSelector.Medium:
                UnityEngine.Debug.Log("Current Level is Medium");
                break;
            case LevelSelector.Hard:
                UnityEngine.Debug.Log("Current Level is Hard");
                break;
            case LevelSelector.Expert:
                UnityEngine.Debug.Log("Current Level is Expert");
                break;
        }
    }
}
