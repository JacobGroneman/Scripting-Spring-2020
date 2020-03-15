using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Pokemon : MonoBehaviour
{
    public string
        name,
        nickname,
        description;

    public int
        pokeDexNumber,
        attack,
        defense,
        spAttack,
        spDefense,
        speed,
        stamina,
        level,
        expPoints;

    public Move
        move1,
        move2,
        move3,
        move4;

    public Pokemon
    (string name, string nickname, string description, int pokeDexNumber, int attack, int defense,
        int spAttack, int spDefense, int speed, int stamina, int level, int expPoints, Move move1,
        Move move2, Move move3, Move move4)
    {
        this.name = name;
        this.nickname = nickname;
        this.description = description;
        this.pokeDexNumber = pokeDexNumber;
        this.attack = attack;
        this.defense = defense;
        this.spAttack = spAttack;
        this.spDefense = spDefense;
        this.speed = speed;
        this.stamina = stamina;
        this.level = level;
        this.expPoints = expPoints;
        this.move1 = move1;
        this.move2 = move2;
        this.move3 = move3;
        this.move4 = move4;
    }
}
