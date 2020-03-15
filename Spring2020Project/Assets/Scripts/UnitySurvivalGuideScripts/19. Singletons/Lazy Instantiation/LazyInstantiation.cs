using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazyInstantiation : MonoBehaviour
{
  private static LazyInstantiation _instance;

  public static LazyInstantiation Instance
  {
    get
    {
      if (_instance == null)
      {
        GameObject gameObj = new GameObject("Generic Manager"); // <--Lazy
        gameObj.AddComponent<LazyInstantiation>();                    // Instantiation
      }
      return _instance;
    }
  }

  private void Awake()
  {
    _instance = this;
  }

  public void GenericMethod()
  {
    Debug.Log("Stuff Happens");
  }
}
