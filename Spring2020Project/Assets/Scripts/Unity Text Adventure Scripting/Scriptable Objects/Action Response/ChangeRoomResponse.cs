using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "TextAdventure/ActionResponse/ChangeRoom")]
public class ChangeRoomResponse : ActionResponse
{
    public Room roomToChange;
    
    public override bool DoActionResponse(GameController gameController)
    {
        if (gameController.roomNavigation.currentRoom.roomName == requiredString)
        {
            gameController.roomNavigation.currentRoom = roomToChange;
            gameController.DisplayRoomText();
            return true;
        }
        return false;
    }
}
