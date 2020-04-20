using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogPractice : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    public float typingSpeed;
    
    private int _index;

    IEnumerator Typer()
    {
        foreach (char letter in sentences[_index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextSentence()
    {
        
    }
}
