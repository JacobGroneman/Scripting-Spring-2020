using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class customer
{
    public string firstName;
    public string lastName;
    public bool gender;
    public int age;
    public string occupation;

    public customer(string firstName, string lastName, bool gender, int age, string occupation)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.gender = gender;
        this.age = age;
        this.occupation = occupation;
    }

}

public class CustomerDatabaseChallenge : MonoBehaviour
{
    public customer ted, ash, raquel;
    
    void Start()
    {
        ted = new customer("Ted", "Bear", true, 43, "Snuggles and Such");
        ash = new customer("Ash", "Yamaguchi", false, 19, "Livin' it up");
        raquel = new customer("Raquel", "Boinga-lingus",  false, 74, "Stealing Things");
    }
}