using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class cpCmdDown : cpICommand
{
    private Transform _player;
    private float _speed;

    public cpCmdDown(Transform player, float speed)
    {
        this._player = player;
        this._speed = speed;
    }
    
    public void Execute()
    {
        _player.Translate(Time.deltaTime * _speed * Vector3.down);
    }

    public void Undo()
    {
        
    }
}
