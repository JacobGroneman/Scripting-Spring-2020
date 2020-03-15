using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using Debug = System.Diagnostics.Debug;

public class YouHaveBeenNamedChallenge : MonoBehaviour
{
    private bool hasNames = true;
    public List<string> names = new List<string>() 
        {"Jennifer", "Bill", "Jerry", "Kim", "Brodane", "Santa", "Darth Brooks"};

    void Start()
    {
        foreach (var name in names)
        {
            UnityEngine.Debug.Log(name);
        }
    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PrintAndRemoveNames();
        }
    }

    public void PrintAndRemoveNames()
    {
        var nameRemoved = names[Random.Range(0, names.Count)];
        names.Remove(nameRemoved);
        
        foreach (var name in names)
        {
            UnityEngine.Debug.Log(name);
        }
        
        UnityEngine.Debug.Log("Name Removed: " + nameRemoved);
    }
}
