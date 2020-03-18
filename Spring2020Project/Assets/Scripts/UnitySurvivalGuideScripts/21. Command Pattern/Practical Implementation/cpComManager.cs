using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class cpComManager : MonoSingleton<cpComManager>
{
    private List<cpICommand> _commandBuffer = new List<cpICommand>();

    public void AddCommand(cpICommand command)
    {
        _commandBuffer.Add(command);
    }

    public void Rewind()
    {
        StartCoroutine(RewindRoutine());
    }
    public void Replay()
    {
        StartCoroutine(ReplayRoutine());
    }

    IEnumerator RewindRoutine()
    {
        Debug.Log("Rewinding...");
        foreach (var command in Enumerable.Reverse(_commandBuffer))
        {
            command.Undo();
            yield return new WaitForEndOfFrame();
        }
        Debug.Log("Finished Rewinding");
    }

    IEnumerator ReplayRoutine()
    {
        Debug.Log("Replaying...");
        foreach (var command in _commandBuffer)
        {
            command.Undo();
            yield return new WaitForEndOfFrame();
        }

        Debug.Log("Finished Replaying");
    }


}
