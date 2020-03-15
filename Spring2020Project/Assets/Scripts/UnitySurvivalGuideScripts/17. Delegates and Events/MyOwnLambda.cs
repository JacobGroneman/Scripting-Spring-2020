using System;
using UnityEngine;
using Color = System.Drawing.Color;

public class MyOwnLambda : MonoBehaviour
{
    private Func<MyOwnLambda, Vector3> RespawnPosition;

    private void Start()
    {
        ActivateLambdas();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            RespawnPosition?.Invoke(this);
        }
    }

    private void ActivateLambdas()
    {
        RespawnPosition = (objectToRespawn) 
            => objectToRespawn.GetComponent<Transform>().position = Vector3.zero;
        
    }
}
