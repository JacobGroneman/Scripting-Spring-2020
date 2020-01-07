using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ExampleScript : MonoBehaviour
{
    // public Transform myTransform;
    private Rigidbody myRigidbody;
    
    // Start is called before the first frame update
    void Start()

    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        myRigidbody.AddForce(Vector3.up * 50);
       // myTransform.transform.position = Vector3.up * Time.deltaTime;
    }
}