using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextInput : MonoBehaviour
{
    public InputField inputField;
    private GameController _gameController;
    
    private void Awake()
    {
        _gameController = GetComponent<GameController>();
        inputField.onEndEdit.AddListener(AcceptStringInput);
    }

    void AcceptStringInput(string userInput)
    {
        userInput = userInput.ToLower();
        _gameController.LogStringWithReturn(userInput);
        InputComplete();
    }

    void InputComplete()
    {
        _gameController.DisplayLogText();
        inputField.ActivateInputField();
        inputField.text = null;
    }
}
