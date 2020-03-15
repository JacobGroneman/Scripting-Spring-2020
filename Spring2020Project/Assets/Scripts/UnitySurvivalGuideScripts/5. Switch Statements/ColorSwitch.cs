using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSwitch : MonoBehaviour
{
    public GameObject colorSwitchingCube;
    private int _value = 5;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _value = 0;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _value = 2;
        }  
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _value = 3;
        }  
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            _value = 4;
        }

        switch (_value)
        {
            case 0:
                colorSwitchingCube.GetComponent<Renderer>().material.color = Color.blue;
                break;
            case 1:
               colorSwitchingCube.GetComponent<Renderer>().material.color = Color.red;
                break;
            case 2:
                colorSwitchingCube.GetComponent<Renderer>().material.color = Color.green;
                break;
            case 3:
                colorSwitchingCube.GetComponent<Renderer>().material.color = Color.black;
                break;
            default:
                colorSwitchingCube.GetComponent<Renderer>().material.color = Color.white;
                break;
        }
    }
}
