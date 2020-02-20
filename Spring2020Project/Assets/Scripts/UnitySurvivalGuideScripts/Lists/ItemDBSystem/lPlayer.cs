using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lPlayer : MonoBehaviour
{
   public lItem[] inventory = new lItem[10];
   private lItemDatabase _itemDatabase;

   private void Start()
   {
      _itemDatabase = GameObject.Find("ItemDatabase").GetComponent<lItemDatabase>();
   }

   private void Update()
   {
      if (Input.GetKeyDown(KeyCode.Space))
      {
         _itemDatabase.AddItem(0, this);
      }
      
      else if (Input.GetKeyDown(KeyCode.R))
      {
         _itemDatabase.DeleteItem(0, this);
      }
   }
}
