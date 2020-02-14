using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utility
{
    public static void CreateGameObject()
    {
        GameObject.CreatePrimitive(PrimitiveType.Cube);
    }
    public static void SetPositionZero(GameObject obj)
    {
      obj.transform.position = Vector3.zero;  
    }
}
