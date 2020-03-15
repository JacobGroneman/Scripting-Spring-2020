using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnFunction : MonoBehaviour
{
    public int total, total2,
        total3;

    void Start()
    {
        total = _Sum(5, 3);
        total2 = _Sum(34, 57);
        total3 = _Sum(28, 77) / _Product(32, 14);
    }

   
    void Update()
    {
        
    }

    private int _Sum(int a, int b)
    {
        return a + b;
    }

    private int _Product(int x, int y)
    {
        return x * y;
    }
}
