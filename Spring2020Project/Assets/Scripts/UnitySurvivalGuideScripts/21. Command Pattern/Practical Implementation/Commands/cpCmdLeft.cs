using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cpCmdLeft : cpICommand
{
    private Transform _player;
    private float _speed;

    public cpCmdLeft(Transform player, float speed)
    {
        this._player = player;
        this._speed = speed;
    }
    
    public void Execute()
    {
        _player.Translate(Time.deltaTime * _speed * Vector3.left);
    }

    public void Undo()
    {
        _player.Translate(Time.deltaTime * _speed * Vector3.right);
    }
}
