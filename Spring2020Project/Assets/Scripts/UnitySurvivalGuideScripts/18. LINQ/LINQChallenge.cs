using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
public class LINQChallenge : MonoBehaviour
{
    public int[] grades = 
        {32, 85, 90, 97, 38, 65, 63, 87, 95, 92, 95, 84, 32, 45, 63, 69};

    void Start()
    {
        var passingGrades = grades.Where((g) => g > 69);
        foreach (var grade in passingGrades)
        {
            Debug.Log(grade);
        }
    }
}
