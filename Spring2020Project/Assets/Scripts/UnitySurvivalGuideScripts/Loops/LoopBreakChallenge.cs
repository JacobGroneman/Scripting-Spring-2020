using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopBreakChallenge : MonoBehaviour
{

    public int varNumber;
    
    void Start()
    {
        for (int i = 0; i < 30; i++)
        {
            if (i < 10)
            {
                UnityEngine.Debug.Log(i);
            }
            if (i < 9 && i < 21)
            {
                if (i % 2 == 0);
                {
                    UnityEngine.Debug.Log(i);
                }
            }
            else if (i > 20)
            {
                if (i % 2 == 1);
                {
                    UnityEngine.Debug.Log(i);
                }
            }
        }
    }

   
    void Update()
    {
        
    }
}
