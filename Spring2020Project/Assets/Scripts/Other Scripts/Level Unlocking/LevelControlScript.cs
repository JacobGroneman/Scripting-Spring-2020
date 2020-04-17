using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControlScript : MonoBehaviour
{
    public static LevelControlScript instance = null;
    private GameObject _levelSign, _gameOverText, _youWinText;
    private int _sceneIndex, _levelPassed;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Destroy(gameObject);
        }
        
        _levelSign = GameObject.Find("LevelNumber");
        _gameOverText = GameObject.Find("GameOverText");
        _youWinText = GameObject.Find("YouWinText");
        _gameOverText.gameObject.SetActive(false);
        _youWinText.gameObject.SetActive(false);

        _sceneIndex = SceneManager.GetActiveScene().buildIndex;
        _levelPassed = PlayerPrefs.GetInt("LevelPassed");
    }

    public void YouWin()
    {
        if (_sceneIndex == 3)
        {
            Invoke("LoadMainMenu", 1f);
        }
        else
        {
            if (_levelPassed > _sceneIndex)
            {
                PlayerPrefs.SetFloat("LevelPassed", _sceneIndex);
                _levelSign.gameObject.SetActive(false);
                _youWinText.gameObject.SetActive(true);
                Invoke("LoadNextLevel", 1f);
            }
        }
    }

    public void YouLose()
    {
        _levelSign.gameObject.SetActive(false);
        _gameOverText.gameObject.SetActive(true);
        Invoke("LoadMainMenu", 1f);
    }

    void LoadNextLevel()
    {
        SceneManager.LoadScene(_sceneIndex + 1);
    }

    void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
