using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public HbPPlayer player;
    
    void Update()
    {
        #region PlayerHealth
        
        if (Input.GetKeyDown(KeyCode.H))
        {
            player.ReceiveHealth(5);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            player.ReceiveDamage(5);
        }
        
        #endregion
    }
}
