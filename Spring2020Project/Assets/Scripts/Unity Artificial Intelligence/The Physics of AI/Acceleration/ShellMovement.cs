using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShellMovement : MonoBehaviour
{
    public GameObject explosion;
    private float _mass = 10f; //(Kilograms)
    private float _force = 200f;
    private float _acceleration;
    private float _velocityZ; //(speed)'
   
    private float _velocityY;
    private float _gAcceleration;
    private float _gravityY = 9.81f;

    void OnCollisionEnter(Collider col)
    {
        if (col.gameObject.tag == "Tank")
        {
            GameObject exp = Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(exp, 0.5f);
            Destroy(this.gameObject);
        }
    }

    void LateUpdate()
    {
        //Z Acceleration
        _acceleration = (_force / _mass);
        _velocityZ += _acceleration * Time.deltaTime;
        
        //Y Acceleration
        _gAcceleration = (_gravityY / _mass);
        _velocityY += _gAcceleration * Time.deltaTime;
        
        this.transform.Translate(0, _velocityY, _velocityZ);

        //Z Deceleration
        _force -= .5f;

        if (_force <= 0)
        {
            _force = 0;
        }
    }
}
