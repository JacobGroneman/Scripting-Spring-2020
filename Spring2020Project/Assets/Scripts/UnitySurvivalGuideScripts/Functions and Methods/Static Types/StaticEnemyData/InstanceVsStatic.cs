using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameThings
{
    public string itemName;
    public int itemId;
    public static int itemCount;

    public GameThings(string itemName, int itemId)
    {
        this.itemName = itemName;
        this.itemId = itemId;
        itemCount++; //Static makes the function count all GameThing Instances.
    }
}

public class InstanceVsStatic : MonoBehaviour
{
    void Start()
    {
        GameThings bread = new GameThings("Bread", 1);
        GameThings waffle = new GameThings("Waffle", 02);
        UnityEngine.Debug.Log("Item Count: " + GameThings.itemCount);
    }
}
