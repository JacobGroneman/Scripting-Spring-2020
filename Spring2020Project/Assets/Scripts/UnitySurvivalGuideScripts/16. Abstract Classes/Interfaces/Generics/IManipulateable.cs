using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public interface IManipulateable<T>
{
    void VariableToManipulate(T variable);
}

public class GameObjectVar : MonoBehaviour, IManipulateable<GameObject>
{
    public void VariableToManipulate(GameObject variable)
    {
        variable = new GameObject();
    }
}

public class IntVar : MonoBehaviour, IManipulateable<int>
{
    public void VariableToManipulate(int variable)
    {
        variable = 5;
    }
}
