using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Bank
{
    public string
        branchName,
        location;
    
    public int cashInVault;

    public void CheckBalance()
    {
        UnityEngine.Debug.Log("Checking Balance: " + branchName);
    }
    
    public void WithDrawl()
    {
        UnityEngine.Debug.Log("Withdrawing Money From: " + branchName);
    }

    public void Deposit()
    {
        UnityEngine.Debug.Log("Depositing Money To: " + branchName);
    }
    
}
