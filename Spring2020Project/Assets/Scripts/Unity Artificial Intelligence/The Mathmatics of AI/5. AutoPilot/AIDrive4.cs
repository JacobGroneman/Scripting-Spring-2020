using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIDrive4 : MonoBehaviour
{
    public float speed = 10f;
    public float rotationSpeed = 100;
    public GameObject fuel;
    private bool _autoPilot = false;
    
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        
        transform.Translate(0, translation, 0);
        transform.Rotate(0, 0, -rotation);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            CalculateDistance();
            CalculateAngle();
        }
        
        //Auto-Pilot Mode
        if (Input.GetKeyDown(KeyCode.T))
        {
            _autoPilot = !_autoPilot;
        }

        if (_autoPilot == true)
        {
            //Stops When Arriving at the Object
            if (CalculateDistance() > 5)
            {
                AutoPilot();   
            }
        }
    }

    float CalculateDistance()
    {
        //Primitive Method
        Vector3 tankPosition = this.gameObject.transform.position;
        Vector3 fuelPosition = fuel.transform.position;

        float distance = Mathf.Sqrt(
            Mathf.Pow(tankPosition.x - fuelPosition.x, 2) +
            Mathf.Pow(tankPosition.y - fuelPosition.y, 2) + 
            Mathf.Pow(tankPosition.z - fuelPosition.z, 2));
        
        Debug.Log("Distance from Fuel: " + distance);
        
        //Fast Method
        float unityDistance = Vector3.Distance(tankPosition, fuelPosition);
        
        Debug.Log("Distance from Fuel: " + unityDistance);
        
        //(Fast Method and Primitive Method are the same).
        
        return distance;
    }

    private float _autoSpeed = 0.1f;
    
    void AutoPilot()
    {
        //this.transform.LookAt(fuel.transform.position, selfTransform.up);
        CalculateAngle();
        this.transform.Translate(this.transform.up * _autoSpeed, Space.World);
    }

    //Cross product Calculation
    Vector3 Cross(Vector3 v, Vector3 w)
    {
        float xMult = (v.y * w.z) - (v.z * w.y);
        float yMult = (v.z * w.x) - (v.x * w.z);
        float zMult = (v.x * w.y) - (v.y * w.x);
        
        Vector3 crossProduct = new Vector3(xMult, yMult, zMult);
        return crossProduct;
    }

    void CalculateAngle()
    {
        Vector3 tankForward = this.transform.forward;
        Vector3 fuelDirection = fuel.transform.position - this.transform.position;
        float length = tankForward.magnitude;

        float dotProduct = (tankForward.x * fuelDirection.x) + (tankForward.y * fuelDirection.y);
        float angle = Mathf.Acos(dotProduct / (tankForward.magnitude * fuelDirection.magnitude));
        
        Debug.Log("Angle: " + angle * Mathf.Rad2Deg);
        Debug.Log("Unity Angle: " + Vector3.Angle(tankForward, fuelDirection));
        
        Debug.DrawRay(this.transform.position, tankForward * 10, Color.green, 2f);
        Debug.DrawRay(this.transform.position, fuelDirection * 10, Color.red, 2f);

        //Cross Product
        int clockWise = 1;
        
        if (Cross(tankForward, fuelDirection).z < 0)
        {
            clockWise = -1;
        }

        //Unity Angle*
        float unityAngle = Vector3.SignedAngle(tankForward, fuelDirection, this.transform.forward);
        
        //Rotates to the calculated value.
        this.transform.Rotate(0,0,(angle * Mathf.Rad2Deg * clockWise) * 0.2f /* <-- Smoother */);
        
        //*The Unity Rotate Would Be -->
        //this.transform.Rotate( 0, 0, unityAngle);
    }
}
