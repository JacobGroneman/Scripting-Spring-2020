using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = System.Diagnostics.Debug;

public class iEnumeratorForLoop : MonoBehaviour
{
    public int timerAmount = 100;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Timer());
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    IEnumerator Timer()
    {
        for (int i = 100; i > 0; i--)
        {
            timerAmount--;
            UnityEngine.Debug.Log("Time Left: " + timerAmount);
            yield return  new WaitForSeconds(1.0f);
        }
    }
}
