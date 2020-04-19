using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerDisplayPractice : MonoBehaviour
{
    private int _days, _hours, _minutes, _seconds;
    
    public Text timerUI;
    
    private string _timerText = "0:0:0:0";
    private bool _isTimerStarted = false;

    void Start()
    {
        timerUI.text = _timerText;
    }

    void Update()
    {
        if (_isTimerStarted == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                StartCoroutine(StartTimer());
                _isTimerStarted = true;
            }
        }
    }

    IEnumerator StartTimer()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            _seconds++;
            
            if (_seconds == 60)
            {
                _seconds = 0;
                _minutes++;
            }

            if (_minutes == 60)
            {
                _minutes = 0;
                _hours++;
            }

            if (_hours == 24)
            {
                _hours = 0;
                _days++;
            }

            timerUI.text = 
                _days.ToString() + ":" + _hours.ToString() + 
                ":" + _minutes.ToString() + ":" + _seconds.ToString();
            Debug.Log(
                _days.ToString() + ":" + _hours.ToString() + 
                ":" + _minutes.ToString() + ":" + _seconds.ToString());
        }
    }
}
