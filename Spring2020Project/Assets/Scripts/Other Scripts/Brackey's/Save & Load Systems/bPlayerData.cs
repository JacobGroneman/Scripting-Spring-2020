using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class bPlayerData : MonoBehaviour
{
    public int level;
    public float health;
    
    //Vector 3
    public float[] position;

    public bPlayerData(bPlayer player)
    {
        level = player.level;
        health = player.health;
        
        position = new float[3];
        var currentPosition = player.transform.position;
        position[0] = currentPosition.x;
        position[1] = currentPosition.y;
        position[2] = currentPosition.z;
    }
}
