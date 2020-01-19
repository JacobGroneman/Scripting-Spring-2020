using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizCalculator : MonoBehaviour
{
    public float quizGrade1, quizGrade2, quizGrade3, quizGrade4, quizGrade5;
    
    // Start is called before the first frame update
    void Start()
    {
        quizGrade1 = Random.Range(0f, 100f);
        quizGrade2 = Random.Range(0f, 100f);
        quizGrade3 = Random.Range(0f, 100f);
        quizGrade4 = Random.Range(0f, 100f);
        quizGrade5 = Random.Range(0f, 100f);

        float quizGradeAverage = (quizGrade1 + quizGrade2 + quizGrade3 +
                                  quizGrade4 + quizGrade5) / 5;

        quizGradeAverage = Mathf.Round(quizGradeAverage * 100f) / 1000f;

        UnityEngine.Debug.Log("The Grade Average is: " + quizGradeAverage);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
