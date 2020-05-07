using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemiespmp1 : MonoBehaviour, IDamagable
{
    public int Health { get; set; }
    public void Damage(int damageAmount)
    {
        var _color = this.gameObject.GetComponent<MeshRenderer>().material.color;

        if (damageAmount >= 75)
        {
            _color = Color.magenta;
        }
        else if (damageAmount < 75 && damageAmount >= 30)
        {
            _color = Color.blue;
        }
        else if (damageAmount < 30 && damageAmount >= 0)
        {
            _color = Color.black;
        }
    }
}
