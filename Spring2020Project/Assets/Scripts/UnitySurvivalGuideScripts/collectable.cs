using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectable : MonoBehaviour
{
    private void OnTriggerEnter()
    {
        if (tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
