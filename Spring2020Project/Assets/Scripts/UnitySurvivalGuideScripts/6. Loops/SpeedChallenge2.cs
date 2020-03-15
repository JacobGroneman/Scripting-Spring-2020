using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpeedChallenge2 : MonoBehaviour
{
    public int speed;
    public int maxSpeed;
   
    void Start()
    {
        StartCoroutine(speedCalculator());
        maxSpeed = Random.Range(60, 120);
    }


    void Update()
    {
        
    }
    IEnumerator speedCalculator()
    {
        while (true)
        {
            speed += 5;
            yield return new WaitForSeconds(.5f);
            if (maxSpeed < speed)
            {
                break;
            }
        }
    }
}
