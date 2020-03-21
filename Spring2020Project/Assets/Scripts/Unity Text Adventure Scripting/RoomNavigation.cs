using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomNavigation : MonoBehaviour
{
    public Room currentRoom;
    private GameController _controller;
    
    Dictionary<string, Room> _exitDictionary = new Dictionary<string, Room>();

    private void Awake()
    {
        _controller = GetComponent<GameController>();
    }

    public void UnpackExitsInRoom()
    {
        for (int i = 0; i < currentRoom.exits.Length; i++)
        {
            _exitDictionary.Add(currentRoom.exits[i].keyWord, currentRoom.exits[i].valueRoom);
            _controller.interactionDescriptionsInRoom.Add(currentRoom.exits[i].exitDescription);
        }
    }

    public void AttemptToChangeRooms(string directionNoun)
    {
        if (_exitDictionary.ContainsKey(directionNoun))
        {
            currentRoom = _exitDictionary[directionNoun];
            _controller.LogStringWithReturn("You go " + directionNoun);
        }
        else
        {
            _controller.LogStringWithReturn("You cannot go " + directionNoun);
        }
    }

    public void ClearExits()
    {
        _exitDictionary.Clear();
    }
}
