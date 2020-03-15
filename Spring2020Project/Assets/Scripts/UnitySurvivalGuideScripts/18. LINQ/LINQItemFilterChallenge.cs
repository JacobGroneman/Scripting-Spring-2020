using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[System.Serializable]
public class LINQItems
{
    public string
        name;
    
    public int
        id, buff;
}

public class LINQItemFilterChallenge : MonoBehaviour
{
    public LINQItems[] items;
    
    void Start()
    {
        var item3Found = items.Any(linqItems => linqItems.id == 3);
        var over20 = items.Where(item => item.buff > 20);
        var average = items.Average(item => item.buff);

        Debug.Log(item3Found);
        
        foreach (var item in over20)
        {
            Debug.Log(item.name);
        }
        
        Debug.Log(average);
    }
}
