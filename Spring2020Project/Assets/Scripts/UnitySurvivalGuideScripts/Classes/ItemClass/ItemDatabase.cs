using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    private Item1 _sword, _hammer, _gun;
    
    void Start()
    {
        _sword = CreateItem("Sword", 0, "A Sword");
        _hammer = CreateItem("Hammer", 01, "A Hammer");
        _gun = CreateItem("Gun", 03, "Bing Bing");
    }
    
    void Update()
    {
        
    }
    private Item1 CreateItem(string name, int itemID, string description)
    { 
        Item1 item = new Item1(name, itemID, description);
        return item;
    }
}
