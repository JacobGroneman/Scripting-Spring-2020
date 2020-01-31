using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

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
    public int itemCheckerNumber;

    void Start()
    {
        foreach (var item in myItems)
        {
            UnityEngine.Debug.Log(item.itemID + " " + item.name + " " + item.description);
            
            if (Input.GetKeyDown(KeyCode.Alpha1)) ;
            {
                itemCheckerNumber = 1;
            }
            if (Input.GetKeyDown(KeyCode.Alpha2)) ;
            {
                itemCheckerNumber = 2;
            }
            if (Input.GetKeyDown(KeyCode.Alpha3)) ;
            {
                itemCheckerNumber = 3;
            }
            if (Input.GetKeyDown(KeyCode.Alpha4)) ;
            {
                itemCheckerNumber = 4;
            }
            if (Input.GetKeyDown(KeyCode.Alpha5)) ;
            {
                itemCheckerNumber = 5;
            }
            if (Input.GetKeyDown(KeyCode.Alpha6)) ;
            {
                itemCheckerNumber = 6;
            }
            if (Input.GetKeyDown(KeyCode.Alpha7)) ;
            {
                itemCheckerNumber = 7;
            }
            if (Input.GetKeyDown(KeyCode.Alpha8)) ;
            {
                itemCheckerNumber = 8;
            }
            if (Input.GetKeyDown(KeyCode.Alpha9)) ;
            {
                itemCheckerNumber = 9;
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
        switch (itemCheckerNumber)
        {
            case 1:
                foreach (var item in myItems)
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
                break;
            case 2:
                foreach (var item in myItems)
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
                break;
            case 3:
                foreach (var item in myItems)
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
                break;
            case 4:
                foreach (var item in myItems)
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
                break;
            case 5:
                foreach (var item in myItems)
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
                break;
            case 6:
                foreach (var item in myItems)
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
                break;
            case 7:
                foreach (var item in myItems)
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
                break;
            case 8:
                foreach (var item in myItems)
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
                break;
            case 9:
                foreach (var item in myItems)
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
                break;
            default:
                UnityEngine.Debug.Log("You Can Check For An Item By Pressing Keys 1-9");
                break;
        }
    }
}