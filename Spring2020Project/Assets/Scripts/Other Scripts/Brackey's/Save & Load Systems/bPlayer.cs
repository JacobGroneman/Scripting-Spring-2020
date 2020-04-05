using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bPlayer : MonoBehaviour
{
    public int level = 3;
    public float health = 89.5f;

    public void SavePlayer()
    {
        bSaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        bPlayerData data = bSaveSystem.LoadPlayer();

        level = data.level;
        health = data.health;
        Vector3 position;
            position.x = data.position[0];
            position.y = data.position[1];
            position.z = data.position[2];
                transform.position = position;
    }
}
