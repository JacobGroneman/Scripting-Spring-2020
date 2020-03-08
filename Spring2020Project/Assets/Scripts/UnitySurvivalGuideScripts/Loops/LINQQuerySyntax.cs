using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Debug = System.Diagnostics.Debug;

public class LINQQuerySyntax : MonoBehaviour
{
    private int[] _scores = {34, 24, 62, 79, 60, 92, 3, 9, 349, 4, 6};
    
    void Start()
    {
        //Query Linq Syntax
        var searchQuery =
            from score in _scores
            where score > 50
            select score;
        foreach (var searchItem in searchQuery)
        {
            UnityEngine.Debug.Log(searchItem);
        }
        
        //Method Linq Syntax
        var searchMethod = _scores.Where(score => score > 50);
        foreach (var searchItem in searchMethod)
        {
            UnityEngine.Debug.Log(searchItem);
        }
    }
}
