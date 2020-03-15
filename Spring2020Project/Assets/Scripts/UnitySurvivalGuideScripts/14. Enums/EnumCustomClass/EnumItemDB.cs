using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumItemDB : MonoBehaviour
{
    public List<EnumItem> itemDB = new List<EnumItem>();
    
    public void Update()
    {
        itemDB[0].Action();
    }
}
