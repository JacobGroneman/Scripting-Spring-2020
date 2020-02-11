using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
[System.Serializable]
public class Move
{
    public string
        name,
        description;

    public int
        pp,
        type01,
        type02;

    public Move(string name, string description, int pp, int type01, int type02)
    {
        this.name = name;
        this.description = description;
        this.pp = pp;
        this.type01 = type01;
        this.type02 = type02;
    }
}
