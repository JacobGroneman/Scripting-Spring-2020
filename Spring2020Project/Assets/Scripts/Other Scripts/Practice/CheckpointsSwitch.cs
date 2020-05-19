using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class CheckpointsSwitch : MonoBehaviour
{
    private float _currentLevelDistance;
    private GameObject _player;
    private GameObject[] _checkPoints;

    private Text _checkPointText;

    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        _currentLevelDistance = _player.transform.position.x;
        _checkPoints = GameObject.FindGameObjectsWithTag("CheckPoints");
        //Set Text(Research it)    Maybe Like --> [Text.FindTextWithTag("CheckPointText"); 
    }

    void Update()
    {
        _currentLevelDistance = _player.transform.position.x;

        foreach (var checkPoint in _checkPoints)
        {
            if (Math.Abs(_currentLevelDistance - checkPoint.transform.position.x) < .01f)
            {
                _checkPointText.text = "Checkpoint" + checkPoint.name + " Reached!";
            }
        }
    }
}
