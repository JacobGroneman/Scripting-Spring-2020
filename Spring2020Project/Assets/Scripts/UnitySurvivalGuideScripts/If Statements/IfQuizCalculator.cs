using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfQuizCalculator : MonoBehaviour
{
    public float 
        quiz1, quiz2, quiz3, quiz4, quiz5;

    public float average;

    void Start()
    {
        quiz1 = Random.Range(1, 101);
        quiz2 = Random.Range(1, 101);
        quiz3 = Random.Range(1, 101);
        quiz4 = Random.Range(1, 101);
        quiz5 = Random.Range(1, 101);
        
        average = (quiz1 + quiz2 + quiz3 + quiz4 + quiz5)
            /5;
        
        if (average > 90)
        {
            UnityEngine.Debug.Log
            ("The " + 
             "Grade average is: A with " + average + "%.");
        }
        else if (average >= 80 && average < 90)
        {
            UnityEngine.Debug.Log
            ("The " + 
             "Grade average is: B with " + average + "%.");
        }
        else if (average >= 70 && average < 80)
        {
            UnityEngine.Debug.Log
            ("The " + 
             "Grade average is: C with " + average + "%.");
        }
        else
        {
            UnityEngine.Debug.Log
            ("The " + 
             "Grade average is: F with " + average + "%.");
        }
    }

   
    void Update()
    {
       
    }
}
