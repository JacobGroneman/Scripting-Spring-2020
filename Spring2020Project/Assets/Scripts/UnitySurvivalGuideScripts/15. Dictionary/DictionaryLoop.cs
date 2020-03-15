using System.Collections.Generic;
using UnityEngine;

public class DictionaryLoop : MonoBehaviour
{
    public Dictionary<int, DictItem> itemDictionary = new Dictionary<int, DictItem>();
    
    void Start()
    {
        var sword = new DictItem {name = "Sword", itemID = 01};

        var bread = new DictItem {name = "Bread", itemID = 01};

        var cape = new DictItem {name = "Cape", itemID = 03};
        
        itemDictionary.Add(0, sword);
        itemDictionary.Add(1, bread);
        itemDictionary.Add(2, cape);

        foreach (KeyValuePair<int, DictItem> item in itemDictionary)//Dictionary Looping Example
        {
            UnityEngine.Debug.Log
                ("Key: " + item.Key + " Name: " + item.Value.name + " ID: " + item.Value.itemID);
        }
        
        FindKey(60);
    }

    private void FindKey(int keyToFind) //Returns message based on if key exists.
    {
        if (itemDictionary.ContainsKey(keyToFind))
        {
            UnityEngine.Debug.Log("Key " + keyToFind +" exists.");
            var desiredItem = itemDictionary[keyToFind];
        }
        else
        {
            UnityEngine.Debug.Log("Key " + keyToFind + " does not exist.");
        }
    }
}
