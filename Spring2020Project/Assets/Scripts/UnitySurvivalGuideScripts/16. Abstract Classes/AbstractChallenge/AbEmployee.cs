using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbEmployee : MonoBehaviour
{
    public string
        Company = "McDonald's", Employee;

    public abstract void CalculateMonthlySalary();
}
