using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : MonoBehaviour
{
    public Spell fireBlast;
    public int level;
    public int ExpPoints;
    
    void Start()
    { 
        fireBlast = new Spell("Fire Blast", 2, 4, 2);   
    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            fireBlast.CastSpell();
            ExpPoints += fireBlast.experienceGained;
        }

        if (ExpPoints >= 50)
        {
            level = 3; 
        }
    }
}
