using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{
    public GameObject gun, ax, sword, nuclearFire;
    private int _weaponSelectNumber = 0;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            _weaponSelectNumber = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            _weaponSelectNumber = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            _weaponSelectNumber = 3;
        }
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            _weaponSelectNumber = 4;
        }

        switch (_weaponSelectNumber)
        {
            case 1:
                Instantiate(gun, Vector3.zero, Quaternion.identity);
                    UnityEngine.Debug.Log("Gun has been selected");
                break;
            case 2:
                Instantiate(ax, Vector3.zero, Quaternion.identity);
                UnityEngine.Debug.Log("Ax has been selected");
                break;
            case 3:
                Instantiate(sword, Vector3.zero, Quaternion.identity);
                UnityEngine.Debug.Log("Sword has been selected");
                break;
            case 4:
                Instantiate(nuclearFire, Vector3.zero, Quaternion.identity);
                UnityEngine.Debug.Log("Nuclear Fire has been selected, cover your buns, hun!");
                break;
            default:
                UnityEngine.Debug.Log("Please Select your Weapon");
                break;
        }
    }
}
