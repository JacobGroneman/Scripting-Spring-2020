using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedUpdateMoveMethod : MonoBehaviour
{
    void FixedUpdate()
    {
        //this.transform.Translate(0, 0, 0.01f);
        this.transform.Translate(0, 0, Time.deltaTime);
    }
}
