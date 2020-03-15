using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionPlayer : MonoBehaviour
{
    public static Action<int> onDamageReceived;
    public int Health {get; set;}

    private void Start()
    {
        Health = 10;
    }

    void Damage()
    {
        onDamageReceived?.Invoke(Health);
        Health--;
    }
}
