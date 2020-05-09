using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class RotateController : MonoBehaviour
{
    private float _rotationSpeed = 100.0f;
    private float _scaleAmount = 1.0f;
    private float _scaleSpeed = 10.0f;

    void Start()
    {
       this.transform.rotation = Quaternion.identity;
       this.transform.localScale = new Vector3(1, 1, 1);
    }

    void LateUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Rotate(0,  _rotationSpeed * Time.deltaTime, 0);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            this.transform.Rotate(0,  -_rotationSpeed * Time.deltaTime, 0);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(_rotationSpeed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(-_rotationSpeed * Time.deltaTime, 0, 0);
        }
        
        if(Input.GetKey(KeyCode.E))
        {
            this.transform.Rotate(0, 0, _rotationSpeed* Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            this.transform.Rotate(0, 0, -_rotationSpeed* Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Z) && _scaleAmount >= 0)
        {
            _scaleAmount--;
            this.transform.localScale = 
                new Vector3(
                    _scaleAmount, 
                    _scaleAmount, 
                    _scaleAmount);
        }
        else if (Input.GetKey(KeyCode.X) && _scaleAmount < 10)
        {
            _scaleAmount++;
            this.transform.localScale = 
                new Vector3(
                    _scaleAmount, 
                    _scaleAmount, 
                    _scaleAmount);
        }
    }
}
