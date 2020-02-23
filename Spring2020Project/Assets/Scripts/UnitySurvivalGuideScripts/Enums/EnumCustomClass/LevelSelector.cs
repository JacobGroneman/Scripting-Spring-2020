using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelSelector : MonoBehaviour
{
    public enum DifficultyLevel
    {
        Easy, Medium, Hard, Expert
    }

    public DifficultyLevel levelIntensity;

    private void Start()
    {
        SceneManager.LoadScene((int) levelIntensity);
    }
}
