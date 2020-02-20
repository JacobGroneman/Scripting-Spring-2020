using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lItemDatabase : MonoBehaviour
{
    public List<lItem> itemDB = new List<lItem>();

    public void AddItem(int itemID, lPlayer player)
    {
        foreach (var item in itemDB)
        {
            if (item.itemID == itemID)
            {
                UnityEngine.Debug.Log("We have a Match!");
                player.inventory[0] = item;
                return;
            }
            UnityEngine.Debug.Log("There is no Match!");
        }
    }

    public void DeleteItem(int itemID, lPlayer player)
    {
        foreach (var item in itemDB)
        {
            if (item.itemID == itemID)
            {
                player.inventory[0] = null;
            }
        }
    }
}
