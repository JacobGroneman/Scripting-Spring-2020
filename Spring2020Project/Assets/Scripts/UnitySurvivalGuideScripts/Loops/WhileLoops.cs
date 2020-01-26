using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoops : MonoBehaviour
{

    public int drops;


    void Start()
    {
        while (drops < 100)
        {
            UnityEngine.Debug.Log("Drip");
            drops++;
        }
    }


    void Update()
    {

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
