﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EChMain : MonoBehaviour
{
   public delegate void Teleport(Vector3 pos);
   public static event Teleport onTeleport;

   private void Update()
   {
      if (Input.GetKeyDown(KeyCode.Space))
      {
         onTeleport?.Invoke(new Vector3(5, 2, 0));
      } 
   }
}
