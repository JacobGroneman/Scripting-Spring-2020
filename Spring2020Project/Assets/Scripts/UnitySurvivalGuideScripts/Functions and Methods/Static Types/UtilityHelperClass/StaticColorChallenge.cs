using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Color = System.Drawing.Color;

public static class ChangeGameObject
{
    public static void RandomColor(GameObject obj)
    {
        obj.GetComponent<MeshRenderer>().material.color = new UnityEngine.Color
            (Random.value, Random.value, Random.value);
    }
}

public class StaticColorChallenge : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            ChangeGameObject.RandomColor(gameObject);
        }
    }
}
