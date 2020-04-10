using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BRKYSPlayerManager : MonoBehaviour
{
    #region Singleton

    public static BRKYSPlayerManager instance;

    private void Awake()
    {
        instance = this;
    }

    #endregion

    public GameObject player;
}
