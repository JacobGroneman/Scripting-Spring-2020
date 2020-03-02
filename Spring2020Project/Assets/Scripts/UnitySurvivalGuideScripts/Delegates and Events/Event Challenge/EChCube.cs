using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EChCube : MonoBehaviour
{
    private void Start()
    {
        EChMain.onTeleport += ChangePosition;
    }

    private void OnDisable()
    {
        EChMain.onTeleport -= ChangePosition;
    }

    private void ChangePosition(Vector3 pos)
    {
        this.transform.position = pos;
    }
}
