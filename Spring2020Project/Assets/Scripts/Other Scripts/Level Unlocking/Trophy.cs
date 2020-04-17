using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trophy : MonoBehaviour
{
   void OnTriggerEnter(Collider collider)
   {
      LevelControlScript.instance.YouWin();
   }
}
