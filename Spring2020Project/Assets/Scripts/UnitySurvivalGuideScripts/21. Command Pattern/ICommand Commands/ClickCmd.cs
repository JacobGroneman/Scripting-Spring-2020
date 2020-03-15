using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCmd : ICommand
{
    private GameObject _cube;
    private Color _color, _previousColor;

    public ClickCmd(GameObject cube, Color color)
    {
        this._cube = cube;
        this._color = color;
    }
    
    public void Execute()
    {
        _previousColor = _cube.GetComponent<MeshRenderer>().material.color
            = _color;
        _cube.GetComponent<MeshRenderer>().material.color
            = _color;
    }

    public void Undo()
    {
        _cube.GetComponent<MeshRenderer>().material.color
            = _previousColor;
    }
}
