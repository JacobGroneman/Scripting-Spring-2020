using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ReturnDelegateSyntax : MonoBehaviour
{
    public delegate int WordOperations(string word);
    public WordOperations operateWord;
    public string wordOfChoice;
   
    void Start()
    {
        operateWord = ReturnCharacterLength;
        UnityEngine.Debug.Log(operateWord);
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            operateWord?.Invoke(wordOfChoice);
        }
    }

    int ReturnCharacterLength(string word)
    {
        return word.Length;
    }
}
