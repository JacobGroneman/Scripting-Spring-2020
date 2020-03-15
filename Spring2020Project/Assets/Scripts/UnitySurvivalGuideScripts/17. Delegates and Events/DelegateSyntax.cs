using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Color = System.Drawing.Color;

public class DelegateSyntax : MonoBehaviour
{
   public delegate void ChangeColor(Color newColor);
   public ChangeColor onColorChange;

   public delegate void OnComplete();
   public OnComplete onComplete;

   private void Start()
   {
      onColorChange = UpdateColor;
      onColorChange(Color.Green);
      onComplete += Task;
      onComplete += Task2;
      onComplete += Task3;

      onComplete?.Invoke();
   }

   private void Task()
   {
      UnityEngine.Debug.Log("Task 1 Completed!");
   }
   
   private void Task2()
   {
      UnityEngine.Debug.Log("Task 2 Completed!");
   }
   
   private void Task3()
   {
      UnityEngine.Debug.Log("Task 3 Completed!");
   }
   
   private void UpdateColor(Color newColor)
   {
      UnityEngine.Debug.Log("Changing Color To: " + newColor.ToString());
   }
}
