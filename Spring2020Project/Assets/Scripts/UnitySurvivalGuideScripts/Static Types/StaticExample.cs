using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticExample : MonoBehaviour
{ 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Score._score += 10;
        }
    }
    public class Score
    {
        public static int _score;
    }
}
