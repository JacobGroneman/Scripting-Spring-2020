using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [HideInInspector] public RoomNavigation roomNavigation;

    private void Awake()
    {
        roomNavigation = GetComponent<RoomNavigation>();
    }

    void Update()
    {
        
    }

    public void DisplayRoomText()
    {
        string combinedText = roomNavigation.currentRoom.description + "\n";
    }
    
}
