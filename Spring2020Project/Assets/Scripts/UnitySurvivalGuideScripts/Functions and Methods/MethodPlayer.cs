using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MethodPlayer : MonoBehaviour
{
    public int health = 100;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsDead() == false)
        {
            DamageAmount(Random.Range(5, 25));
        }
    }

    public void DamageAmount(int damage)
    {
        health -= damage;
        
        if (IsDead() == true)
        {
            UnityEngine.Debug.Log("The player has died!");
            health = 0;
        }
    }
     bool IsDead()
    {
        return health < 1;
    }
}
