using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIDrive1 : MonoBehaviour
{
    public float speed = 10f;
    public float rotationSpeed = 100;
    public GameObject fuel;
    
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
    }

    void CalculateDistance()
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
    }
}
