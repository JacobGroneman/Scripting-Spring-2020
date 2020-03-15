using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoProperty : MonoBehaviour
{
    public double BankAccount {get; protected set;}

    void Start()
    {
        BankAccount = 5.72;
    }
}
