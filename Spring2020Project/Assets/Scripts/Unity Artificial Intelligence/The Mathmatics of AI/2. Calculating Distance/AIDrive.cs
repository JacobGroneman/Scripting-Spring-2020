using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIDrive : MonoBehaviour
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
}
