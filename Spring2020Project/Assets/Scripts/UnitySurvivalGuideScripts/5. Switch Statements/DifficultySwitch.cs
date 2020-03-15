using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class DifficultySwitch : MonoBehaviour
{
    public int difficultyLevel;
    void Start()
    {
        difficultyLevel = Random.Range(0, 3);
    }

    
    void Update()
    {
        switch (difficultyLevel)
        {
            case 0:
                UnityEngine.Debug.Log("Easy");
                break;
            case 1:
                UnityEngine.Debug.Log("Medium");
                break;
            case 2:
                UnityEngine.Debug.Log("Hard");
                break;    
            default:
                UnityEngine.Debug.Log("No Level");
                break;
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            difficultyLevel -= 1;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            difficultyLevel += 1;
        }

        if (difficultyLevel > 3)
        {
            difficultyLevel = 3;
        }

        if (difficultyLevel < 0)
        {
            difficultyLevel = 0;
        }
    }
}
