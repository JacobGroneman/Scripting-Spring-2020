using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnVoidDelegate : MonoBehaviour
{
    public Func<int> onGetName;
    
   void Start()
   {
       onGetName = () => this.gameObject.name.Length;
       var characterCount = onGetName?.Invoke();
       Debug.Log("Name Length: " + characterCount);
   }
}
