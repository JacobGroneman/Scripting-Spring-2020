using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cpCmdUp : cpICommand
{
    private Transform _player;
    private float _speed;

    public cpCmdUp(Transform player, float speed)
    {
        this._player = player;
        this._speed = speed;
    }
    
    public void Execute()
    {
        _player.Translate(Time.deltaTime * _speed * Vector3.up);
    }

    public void Undo()
    {
        _player.Translate(Time.deltaTime * _speed * Vector3.down);
    }
}
