using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
[System.Serializable]
public class Move
{
    public string
        name,
        description,
        category;

    public int
        type,
        pp,
        power,
        accuracy;

    public Move
    (string name, string description, int type, string category,
        int pp, int power, int accuracy)
    {
        this.name = name;
        this.description = description;
        this.type = type;
        this.category = category;
        this.pp = pp;
        this.power = power;
        this.accuracy = accuracy;
    }
    
    public class MoveDataBase
    {
        public Move darkPulse = new Move
            ("Dark Pulse", "The user releases a horrible aura " +
                            "imbued with dark thoughts. It may also make the target flinch.",
            16, "Special", 15, 80, 100);
    }
}
