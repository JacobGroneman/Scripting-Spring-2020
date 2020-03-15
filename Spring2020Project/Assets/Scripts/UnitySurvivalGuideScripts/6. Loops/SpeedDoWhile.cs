using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedDoWhile : MonoBehaviour
{
    public int speed, maxSpeed;

    void Start()
    {
        maxSpeed = Random.Range(60, 120);
        StartCoroutine(speedCalc());
    }
    
    IEnumerator speedCalc()
    {
        do
        {
            speed += 5;
            yield return new WaitForSeconds(1.0f);
        } while (speed < maxSpeed);
    }
}
