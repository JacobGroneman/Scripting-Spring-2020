using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolBullet : MonoBehaviour
{
    private void OnEnable()
      {
         Invoke(nameof(SetInactive), 1);
      }

      private void SetInactive()
      {
         this.gameObject.SetActive(false);
      }
}