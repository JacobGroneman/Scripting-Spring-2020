using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomNavigation : MonoBehaviour
{
    public Room currentRoom;
    private GameController _controller;

    private void Awake()
    {
        _controller = GetComponent<GameController>();
    }

    public void UnpackExitsInRoom()
    {
        for (int i = 0; i < currentRoom.exits.Length; i++)
        {
            _controller.interactionDescriptionsInRoom.Add(currentRoom.exits[i].exitDescription);
        }
    }
}
