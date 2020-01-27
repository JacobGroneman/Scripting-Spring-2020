using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedLoopChallenge : MonoBehaviour
{
    public int speed;
    public int maxSpeed;
    
    void Start()
    {
        maxSpeed = Random.Range(60, 120);
        StartCoroutine(SpeedRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpeedRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            speed += 5;
        }

        if (speed > maxSpeed)
        { 
           yield break;
        }
    }
}
