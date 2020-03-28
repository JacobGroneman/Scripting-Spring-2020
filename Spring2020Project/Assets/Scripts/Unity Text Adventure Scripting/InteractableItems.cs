using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableItems : MonoBehaviour
{
    [HideInInspector] public List<string> nounsInRoom = new List<string>();
    private List<string> nounsInInventory = new List<string>();
    public Dictionary<string, string> examineDictionary = new Dictionary<string, string>();
    public Dictionary<string, string> takeDictionary = new Dictionary<string, string>();
    private GameController _gameController;

    private void Awake()
    {
        _gameController = GetComponent<GameController>();
    }

    public string GetObjectsNotInInventory(Room currentRoom, int i)
    {
        InteractableObject interactableInRoom = currentRoom.interactableObjectsInRoom[i];

        if (!nounsInInventory.Contains(interactableInRoom.noun))
        {
            nounsInRoom.Add(interactableInRoom.noun);
            return interactableInRoom.description;
        }
        return null;
    }

    public void DisplayInventory()
    {
        _gameController.LogStringWithReturn("You look in your Backpack, Inside you have: ");
        
        foreach (var noun in nounsInInventory)
        { 
            _gameController.LogStringWithReturn(noun);
        }
    }
    
    public void ClearCollections()
    {
        examineDictionary.Clear();
        nounsInRoom.Clear();
        takeDictionary.Clear();
    }

    public Dictionary<string, string> Take(string[] separatedInputWords)
    {
        string noun = separatedInputWords[1];
        if (nounsInRoom.Contains(noun))
        {
            nounsInInventory.Add(noun);
            nounsInRoom.Add(noun);
            return takeDictionary;
        }
        else
        {
            _gameController.LogStringWithReturn("There is no " + noun + " " + "to take.");
            return null;
        }
    }
}
