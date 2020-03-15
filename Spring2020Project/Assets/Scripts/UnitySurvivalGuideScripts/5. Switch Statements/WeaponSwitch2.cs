using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitch2 : MonoBehaviour
{
    public GameObject lightSaber, pistol, nunchucks, flameThrower, chinaStar,
        missileLauncher;
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
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _weaponSelectNumber = 5;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _weaponSelectNumber = 6;
        }

        switch (_weaponSelectNumber)
        {
            case 1:
                Instantiate(lightSaber, Vector3.zero, Quaternion.identity);
                    UnityEngine.Debug.Log("lightSaber has been selected");
                break;
            case 2:
                Instantiate(pistol, Vector3.zero, Quaternion.identity);
                UnityEngine.Debug.Log("pistol has been selected");
                break;
            case 3:
                Instantiate(nunchucks, Vector3.zero, Quaternion.identity);
                UnityEngine.Debug.Log("nunchucks has been selected");
                break;
            case 4:
                Instantiate(flameThrower, Vector3.zero, Quaternion.identity);
                UnityEngine.Debug.Log("Nuclear Fire has been selected, cover your buns, hun!");
                break;
            case 5:
                Instantiate(chinaStar, Vector3.zero, Quaternion.identity);
                UnityEngine.Debug.Log("China Star has been selected, cover your buns, hun!");
                break;
            case 6:
                Instantiate(missileLauncher, Vector3.zero, Quaternion.identity);
                UnityEngine.Debug.Log("MissileLauncher has been selected, cover your buns, hun!");
                break;
            default:
                UnityEngine.Debug.Log("Please Select your Weapon");
                break;
        }
    }
}
