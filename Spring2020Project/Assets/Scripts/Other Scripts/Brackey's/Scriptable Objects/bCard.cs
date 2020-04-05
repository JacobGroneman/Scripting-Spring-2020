using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Brackey's/Card", fileName = "New Card")]
public class bCard : ScriptableObject
{
    public new string name;
    public string description;
    public Sprite artwork;
    public int mannaCost, attack, health;

    public void PrintCardInfoToLog()
    {
        Debug.Log(name + ": " + description + " Card Cost: " + mannaCost);
    }
}
