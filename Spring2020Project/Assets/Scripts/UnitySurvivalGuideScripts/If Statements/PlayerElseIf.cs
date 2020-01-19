using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerElseIf : MonoBehaviour
{
    public int easyDif = 0, mediumDif = 1, hardDif = 2;
    
    public int currentDif = 1;
    
    void Start()
    {
        currentDif = mediumDif;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentDif == easyDif)
        {
            UnityEngine.Debug.Log("you selected easy");
        }
        else if (currentDif == mediumDif)
        {
            UnityEngine.Debug.Log("you selected Medium");
        }
        else if (currentDif == hardDif)
        {
            UnityEngine.Debug.Log("you selected Hard");
        }
        else
        {
            UnityEngine.Debug.Log("The difficulty hasn't been set");
        }
    }
}
