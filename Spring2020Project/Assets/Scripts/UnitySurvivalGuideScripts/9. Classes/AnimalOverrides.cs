using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalOverrides : MonoBehaviour
{
    protected string name;

    protected virtual void Speak()
    {
        UnityEngine.Debug.Log("Speak");
    }
    void Start()
    {
        Speak();
    }
}

public class Dog : AnimalOverrides
{
    protected override void Speak()
    {
        UnityEngine.Debug.Log("Bark!");
    }
}

public class Duck : AnimalOverrides
{
    protected override void Speak()
    {
        UnityEngine.Debug.Log("Quack Y'all!");
    }
}

public class PufferFish : AnimalOverrides
{
    protected override void Speak()
    {
        UnityEngine.Debug.Log("Glub Glub Lol");
    }
}