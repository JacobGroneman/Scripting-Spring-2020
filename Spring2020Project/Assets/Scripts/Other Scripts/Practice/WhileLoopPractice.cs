using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoopPractice : MonoBehaviour
{
   public int seconds = 0;
   private bool _pressed = false;

   void Update()
   {
      if (_pressed == false)
      {
         if (Input.GetKeyDown(KeyCode.Space))
         {
            StartCoroutine(RunTimer());
            _pressed = true;
         }
      }
   }

   private IEnumerator RunTimer()
   {
      while (true)
      {
         yield return new WaitForSeconds(1);
         seconds--;
      }
   }
}
