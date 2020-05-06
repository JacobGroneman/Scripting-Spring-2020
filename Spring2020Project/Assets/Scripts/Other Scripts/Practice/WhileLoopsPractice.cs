using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoopsPractice : MonoBehaviour
{

    public int gumDrops;


    void Start()
    {
        while (gumDrops < 100)
        {
            UnityEngine.Debug.Log("Eating Gumdrops");
            gumDrops++;
        }
    }
    
    IEnumerator Money()
    {
        while (true)
        {
            UnityEngine.Debug.Log("It's true yo");
            yield return new WaitForSeconds(1.00f);
        }
    }
}
