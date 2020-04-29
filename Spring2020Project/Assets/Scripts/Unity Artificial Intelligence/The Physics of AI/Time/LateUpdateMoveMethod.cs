using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LateUpdateMoveMethod : MonoBehaviour
{
    void LateUpdate()
    {
        //this.transform.Translate(0, 0, 0.01f);
        this.transform.Translate(0, 0, Time.deltaTime);
    }
}
