using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Wizard : MonoBehaviour
{
    public Spell[] spells;
    public int level = 1;
    public int ExpPoints;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (var spell in spells)
            {
                if (spell.levelRequired == level)
                {
                    spell.CastSpell();
                    ExpPoints += spell.experienceGained;
                }
            }
        }
        if (ExpPoints >= 1000)
        {
            level = 3;
        }
    }
}
