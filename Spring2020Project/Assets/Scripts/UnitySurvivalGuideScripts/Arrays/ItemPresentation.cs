using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

[System.Serializable]
public partial class Item
{
    public int itemID;
    public string name;
    public string description;
}

public class ItemPresentation : MonoBehaviour
{
    public Item[] myItems;

    void Start()
    {
        foreach (var item in myItems)
        {
            UnityEngine.Debug.Log(item.itemID + " " + item.name + " " + item.description);
           
            //I Need To Find A Shorter Way To Do This!! 
            
            if (Input.GetKeyDown(KeyCode.Alpha1)) ;
            {
                if (item.itemID == 1) ;
                {
                    UnityEngine.Debug.Log("You have It!");
                }
                if (item.itemID != 1)
                {
                    UnityEngine.Debug.Log("You Don't Have it.");
                }
            }
            if (Input.GetKeyDown(KeyCode.Alpha2)) ;
            {
                if (item.itemID == 2) ;
                {
                    UnityEngine.Debug.Log("You have It!");
                }
                if (item.itemID != 2)
                {
                    UnityEngine.Debug.Log("You Don't Have it.");
                }
            }
            if (Input.GetKeyDown(KeyCode.Alpha3)) ;
            {
                if (item.itemID == 3) ;
                {
                    UnityEngine.Debug.Log("You have It!");
                }
                if (item.itemID != 3)
                {
                    UnityEngine.Debug.Log("You Don't Have it.");
                }
            }
            if (Input.GetKeyDown(KeyCode.Alpha4)) ;
            {
                if (item.itemID == 4) ;
                {
                    UnityEngine.Debug.Log("You have It!");
                }
                if (item.itemID != 4)
                {
                    UnityEngine.Debug.Log("You Don't Have it.");
                }
            }
            if (Input.GetKeyDown(KeyCode.Alpha5)) ;
            {
                if (item.itemID == 5) ;
                {
                    UnityEngine.Debug.Log("You have It!");
                }
                if (item.itemID != 5)
                {
                    UnityEngine.Debug.Log("You Don't Have it.");
                }
            }
            if (Input.GetKeyDown(KeyCode.Alpha6)) ;
            {
                if (item.itemID == 6) ;
                {
                    UnityEngine.Debug.Log("You have It!");
                }
                if (item.itemID != 6)
                {
                    UnityEngine.Debug.Log("You Don't Have it.");
                }
            }
            if (Input.GetKeyDown(KeyCode.Alpha7)) ;
            {
                if (item.itemID == 7) ;
                {
                    UnityEngine.Debug.Log("You have It!");
                }
                if (item.itemID != 7)
                {
                    UnityEngine.Debug.Log("You Don't Have it.");
                }
            }
            if (Input.GetKeyDown(KeyCode.Alpha8)) ;
            {
                if (item.itemID == 8) ;
                {
                    UnityEngine.Debug.Log("You have It!");

                }
                if (item.itemID != 8)
                {
                    UnityEngine.Debug.Log("You Don't Have it.");
                }
            }
            if (Input.GetKeyDown(KeyCode.Alpha9)) ;
            {
                if (item.itemID == 9) ;
                {
                    UnityEngine.Debug.Log("You have It!");
                }
                if (item.itemID != 9)
                {
                    UnityEngine.Debug.Log("You Don't Have it.");
                }
            }
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) ;
        {
            int randomID = Random.Range(0, myItems.Length);
            for (int i = 0; i < myItems.Length; i++)
            {
                UnityEngine.Debug.Log(myItems[randomID].itemID + " " + myItems[randomID].name + " " +
                                      myItems[randomID].description);
            }
        }
    }
}