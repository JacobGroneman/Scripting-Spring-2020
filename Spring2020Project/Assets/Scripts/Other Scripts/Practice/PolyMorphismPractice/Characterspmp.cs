using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characterspmp : MonoBehaviour, IDamagable
{
    public int Health { get; set; }
    public void Damage(int damageAmount)
    {
        var _color = this.gameObject.GetComponent<MeshRenderer>().material.color;

        if (damageAmount >= 75)
        {
            _color = Color.green;
        }
        else if (damageAmount < 75 && damageAmount >= 30)
        {
            _color = Color.yellow;
        }
        else if (damageAmount < 30 && damageAmount >= 0)
        {
            _color = Color.red;
        }
    }
}
