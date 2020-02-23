using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using UnityEngine;

public class DictionarySyntax : MonoBehaviour
{
    public Dictionary<int, DictItem> itemDatabase = new Dictionary<int, DictItem>();
    public DictItem 
        sword, shield, gun, revolver, mace, chinaStar;

    private void Start()
    {//Find an easier way, like adding a List.
        itemDatabase.Add(0, sword);
        itemDatabase.Add(1, shield);
        itemDatabase.Add(3, gun);
        itemDatabase.Add(4, revolver);
        itemDatabase.Add(5, mace);
        itemDatabase.Add(6, chinaStar);

        var item = itemDatabase[0];
        item.name = "Sword";
        item.itemID = 0;
    }
}
