using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Color = System.Drawing.Color;
using Random = System.Random;

public class EventCamera : MonoBehaviour
{
   public delegate void ChangeColor(UnityEngine.Color color);
   public static event ChangeColor onColorChange;

   private void Update()
   {
      if(Input.GetKeyDown(KeyCode.K))
      {
         onColorChange?.Invoke(new UnityEngine.Color
            (UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value));
      }
   }
}
