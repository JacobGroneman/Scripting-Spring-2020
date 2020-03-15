using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Item1
{
   public string name;
   public int itemID;
   public string description;
   public Sprite icon;
   
   public Item1(string name, int itemId, string description)
   {
      this.name = name;
      this.itemID = itemId;
      this.description = description;
   }
}
