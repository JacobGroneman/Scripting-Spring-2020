using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

[System.Serializable]
public class EnumItem
{
    public string 
        name, description;

    public int itemID;
    
    public Sprite icon;
    
    public enum ItemType
    {
        Nothing, Weapon, Consumable
    }

    public ItemType TypeOfItem;

    public void Action()
    {
        switch (TypeOfItem)
        {
            case ItemType.Weapon:
                UnityEngine.Debug.Log("This is a " + TypeOfItem);
                break;
            case ItemType.Consumable:
                UnityEngine.Debug.Log("This is a " + TypeOfItem);
                break;
        }
    }

}
