using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESphere : MonoBehaviour
{
    void Start()
    {
        EMain.onClick += Fall;
    }

    private void Fall()
    {
        GetComponent<Rigidbody>().useGravity = true;
    }

}
