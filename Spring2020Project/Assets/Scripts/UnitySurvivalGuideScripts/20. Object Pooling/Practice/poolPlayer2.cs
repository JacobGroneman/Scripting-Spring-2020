using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;

public class poolPlayer2 : MonoBehaviour
{ 
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bomb = PoolManager2.Instance.RequestBomb();
            bomb.transform.position = Vector3.zero;
        }
    }
}
