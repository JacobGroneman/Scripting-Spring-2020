using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class TipCalculator : MonoBehaviour
{
    public int bill = 40;
    public float tip = 20.0f;
    public float totalAmount;

    // Start is called before the first frame update
    void Start()
    {
        float tipAmount = bill * (tip / 100);
        totalAmount = bill + tipAmount;
        UnityEngine.Debug.Log("Your Bill is " + bill + " and your tip amount is " + tipAmount);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
