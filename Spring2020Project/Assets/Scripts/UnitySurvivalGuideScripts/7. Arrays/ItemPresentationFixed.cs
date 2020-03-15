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
    public GameObject theObject;
}

public class ItemPresentationFixed : MonoBehaviour
{
    public Item[] myItems;
    
    void Start()
    {
        //Gives the initial list of items.
        foreach (var item in myItems)
        {
            UnityEngine.Debug.Log(item.itemID + " " + item.name + " " + item.description);
        }
    }

    void Update()
    {
        //Gives a random item.
        if (Input.GetKeyDown(KeyCode.R)) ;
        {
            int randomID = Random.Range(0, myItems.Length);
            for (int i = 0; i < myItems.Length; i++)
            {
                UnityEngine.Debug.Log("Random Object Selected: " + myItems[randomID].itemID + " " + myItems[randomID].name + " " +
                                      myItems[randomID].description);
                Instantiate(myItems[randomID].theObject, Vector3.zero, Quaternion.identity);
            }

            //Item Selection
            foreach (var item in myItems)
            {
                if (Input.GetKeyDown(KeyCode.Alpha1)) ;
                {
                   ItemSelect(1);
                }
                if (Input.GetKeyDown(KeyCode.Alpha2)) ;
                {
                    ItemSelect(2);
                }
                if (Input.GetKeyDown(KeyCode.Alpha3)) ;
                {
                    ItemSelect(3);
                }
                if (Input.GetKeyDown(KeyCode.Alpha4)) ;
                {
                    ItemSelect(4);
                }
                if (Input.GetKeyDown(KeyCode.Alpha5)) ;
                {
                    ItemSelect(5);
                }
                if (Input.GetKeyDown(KeyCode.Alpha6)) ;
                {
                    ItemSelect(6);
                }
                if (Input.GetKeyDown(KeyCode.Alpha7)) ;
                {
                    ItemSelect(7);
                }
                if (Input.GetKeyDown(KeyCode.Alpha8)) ;
                {
                   ItemSelect(8);
                }
                if (Input.GetKeyDown(KeyCode.Alpha9)) ;
                {
                    ItemSelect(9);
                } 
            }
        }
        
        void ItemSelect(int a)
        {
            foreach (var item in myItems)
            {
                if (item.itemID == a) ;
                {
                    //Destroy(); <----This will destroy the previously selected object.
                    UnityEngine.Debug.Log("Item Selected: " + myItems[a].itemID + " " + myItems[a].itemName + " " + myItems[a].description);
                    Instantiate(myItems[a].theObject, Vector3.zero, Quaternion.identity);
                }
            }
        }
    }
}