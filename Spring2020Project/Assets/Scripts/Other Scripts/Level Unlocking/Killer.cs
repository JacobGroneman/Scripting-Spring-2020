﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killer : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        LevelControlScript.instance.YouLose();
    }
}
