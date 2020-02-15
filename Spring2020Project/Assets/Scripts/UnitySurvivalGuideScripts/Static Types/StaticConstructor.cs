using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = System.Diagnostics.Debug;

public class Employee
{
    public int employeeID;
    public string first, last;
    public double salary;
    
    public static string companyName = "Willy Wonka's Chocolate Factory";

    public Employee(int employeeId, string first, string last, double salary) //Gets called for every created instance.
    {
        this.employeeID = employeeId;
        this.first = first;
        this.last = last;
        this.salary = salary;
        UnityEngine.Debug.Log("Employee Activated");
    }

    static Employee() //Gets called once, during the first instance.
    {
        UnityEngine.Debug.Log("Initial Employee Activated");
    }
}

public class StaticConstructor : MonoBehaviour
{
    
    void Start()
    {
        var e1 = new Employee(01, "Bill", "Bills", 11.00);
        var e2 = new Employee(02, "Patrick", "Patricks", 10.50);
        var e3 = new Employee(03, "Chuck", "E. Cheese", 7.25);
    }
}
