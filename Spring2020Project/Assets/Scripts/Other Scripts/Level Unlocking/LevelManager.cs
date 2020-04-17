using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    private Text _text;
    private int _sceneIndex;
    
    void Start()
    {
        _text = GetComponent<Text>();
        _sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    void Update()
    {
        _text.text = "Level: " + _sceneIndex;
    }
}
