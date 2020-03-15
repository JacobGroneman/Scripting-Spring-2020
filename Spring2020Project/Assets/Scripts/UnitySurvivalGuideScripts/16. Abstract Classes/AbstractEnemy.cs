using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractEnemy : MonoBehaviour
{
    public int 
        speed, gems;
    public float 
        health;

    protected virtual void Die()
    {
        Destroy(this);
    }

    public abstract void Attack();
}

public class MossGiant : AbstractEnemy
{
    public override void Attack()
    {
        
    }

    protected override void Die()
    {
        base.Die();
    }
}
