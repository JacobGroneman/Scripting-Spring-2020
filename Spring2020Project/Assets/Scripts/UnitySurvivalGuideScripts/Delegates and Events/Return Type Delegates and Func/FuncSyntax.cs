using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class FuncSyntax : MonoBehaviour
{
    public Func<string, int> operateWord;
    public string inputWord;

    void Start()
    {
        operateWord = ReturnCharacterLength;
        int count = ReturnCharacterLength(inputWord);
        UnityEngine.Debug.Log("Number Length: " + count);
    }
    
    int ReturnCharacterLength(string word)
    {
        return word.Length;
    }
}
