using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Physics;
using UnityEngine;

public class BallJumpSystem : ComponentSystem
{
    protected override void OnUpdate()
    {
        Entities.ForEach((ref PhysicsVelocity physicsVelocity) =>
        {
            if (Input.GetKey(KeyCode.Space))
            {
                physicsVelocity.Linear.y = 5f;
            }
        });
        
    }
}
