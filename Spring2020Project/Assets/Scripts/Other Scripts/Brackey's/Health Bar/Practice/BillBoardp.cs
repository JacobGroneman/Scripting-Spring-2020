using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillBoardp : MonoBehaviour
{
    public Transform cameraTransform;

    private void LateUpdate()
    {
        transform.LookAt(transform.position + cameraTransform.forward);
    }
}
