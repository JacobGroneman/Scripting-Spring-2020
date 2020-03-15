using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = System.Diagnostics.Debug;

public class WeaponStats
{
    public string name;
    public float fireRate;
    public int ammoCount;

    public WeaponStats(string name, float fireRate, int ammoCount)
    {
        this.name = name;
        this.fireRate = fireRate;
        this.ammoCount = ammoCount;
    }
}

public class CustomClasses : MonoBehaviour
{
    private WeaponStats _blaster, _rockets;

    void Start()
    {
        _blaster = new WeaponStats("Blaster", 72.5f, 1000);
        _rockets = new WeaponStats("Rockets", 5f, 23);
        UnityEngine.Debug.Log("Current Weapon: " + _blaster.name);
    }
}
