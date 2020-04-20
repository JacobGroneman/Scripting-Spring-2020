using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogPractice : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    public float typingSpeed;

    public GameObject continueButton;
    public Animator textDisplayAnim;
    private AudioSource _source;
    
    private int _index;

    void Start()
    {
        _source = GetComponent<AudioSource>();
        StartCoroutine(Typer());

    }
    
    void Update()
    {
        if (textDisplay.text == sentences[_index])
        {
            continueButton.SetActive(true);
        }
    }

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
        _source.Play();
        textDisplayAnim.SetTrigger("Change");
        continueButton.SetActive(false);
        
        if (_index < sentences.Length - 1)
        {
            _index++;
            textDisplay.text = " ";
            StartCoroutine(Typer());
        }
        else
        {
            textDisplay.text = " ";
            continueButton.SetActive(false);
        }
        
    }
}
