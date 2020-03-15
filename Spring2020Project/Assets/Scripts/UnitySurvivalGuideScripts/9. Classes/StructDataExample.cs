using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StructDataExample : MonoBehaviour
{
    Thing _sword = new Thing("Sword", 1);
    Thing2 _bread;
    
    void Start()
    {
        _bread.name = "Bread";
        _bread.itemID = 2;
        
        UnityEngine.Debug.Log("Name Before Value Change: " + _sword.name);
        ChangeValue(_sword);
        UnityEngine.Debug.Log("Name After Value Change: " + _sword.name);
        
        UnityEngine.Debug.Log("Name Before Value Change: " + _bread.name);
        ChangeValue(_bread);
        UnityEngine.Debug.Log("Name After Change Value: " + _bread.name);
    }
    
    void ChangeValue(Thing structItem) //Value Type
    {
        structItem.name = "Cake";
    }

    void ChangeValue(Thing2 classItem)  //Reference Type
    {
        classItem.name = "Master Sword";
    }
    
}

//Classes and Structs
public struct Thing
{
    public string name;
    public int itemID;

    public Thing(string name, int itemID)
    {
        this.name = name;
        this.itemID = itemID;
    }
}

public class Thing2
{
    public string name;
    public int itemID;

    public Thing2(string name, int itemID)
    {
        this.name = name;
        this.itemID = itemID;
    }
}
