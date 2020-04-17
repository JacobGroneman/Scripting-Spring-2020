using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    public Button level02Button, level03Button;
    private int _levelPassed;

    void Start()
    {
        _levelPassed = PlayerPrefs.GetInt("LevelPassed");
        level02Button.interactable = false;
        level03Button.interactable = false;
        
        switch (_levelPassed)
        {
            case 1:
                level02Button.interactable = true;
                break;
            case 2:
                level02Button.interactable = true;
                level03Button.interactable = true;
                break;
        }
    }

    public void LevelToLoad(int level)
    {
        SceneManager.LoadScene(level);
    }

    public void ResetPlayerPreferences()
    {
        level02Button.interactable = false;
        level03Button.interactable = false;
        PlayerPrefs.DeleteAll();
    }
    
    
    
}
