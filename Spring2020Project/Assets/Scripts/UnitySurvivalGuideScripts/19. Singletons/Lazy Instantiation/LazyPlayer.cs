using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazyPlayer : MonoBehaviour
{
    private void Start()
    {
        LazyInstantiation.Instance.GenericMethod();
    }
}
