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
        char[] delimiterCharacters = {'_'};
        string[] separatedInputWords = userInput.Split(delimiterCharacters);
        for (int i = 0; i < _gameController.inputActions.Length; i++)
        {
            InputAction inputAction = _gameController.inputActions[i];
            if (inputAction.keyWord == separatedInputWords[0])
            {
                inputAction.RespondToInput(_gameController, separatedInputWords);
            }
        }
        InputComplete();
    }

    void InputComplete()
    {
        _gameController.DisplayLogText();
        inputField.ActivateInputField();
        inputField.text = null;
    }
}
