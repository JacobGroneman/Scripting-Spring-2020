using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsSwitch : MonoBehaviour
{
    public int points;

    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            points = 50;
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            points = 100;
        }
        else if (Input.GetKeyDown(KeyCode.O))
        {
            points = 0;
        }

        switch (points)
        {
            case 50:
                UnityEngine.Debug.Log("50 Points Yo");
                break;
            case 100:
                UnityEngine.Debug.Log("100 Points Bro");
                break;
            default:
                UnityEngine.Debug.Log("We only accept 50s or" +
                                      "100s at this location Sir.");
                break;
        }
    }


}
