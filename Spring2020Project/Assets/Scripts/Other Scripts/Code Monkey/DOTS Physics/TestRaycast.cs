using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;
using Unity.Mathematics;
using Unity.Physics;
using Unity.Physics.Systems;
using RaycastHit = Unity.Physics.RaycastHit;

public class TestRaycast : MonoBehaviour
{
    private Entity Raycast(float3 fromPosition, float3 toPosition)
    {
        BuildPhysicsWorld buildPhysicsWorld =
        World.DefaultGameObjectInjectionWorld.GetExistingSystem<BuildPhysicsWorld>();
        CollisionWorld collisionWorld = buildPhysicsWorld.PhysicsWorld.CollisionWorld;

        RaycastInput raycastInput = new RaycastInput
        {
            Start = fromPosition, End = toPosition, Filter =
                new CollisionFilter
                {
                    BelongsTo = ~0u,          //Research "~" operand/
                    CollidesWith = ~0u,
                    GroupIndex = 0,
                }

        };
                //Hit Something
        Unity.Physics.RaycastHit rayCastHit = new Unity.Physics.RaycastHit();

        if (collisionWorld.CastRay(raycastInput, out rayCastHit))
        {
            Entity hitEntity =
                buildPhysicsWorld.PhysicsWorld.Bodies[rayCastHit.RigidBodyIndex].Entity;
            return hitEntity;
        }
        else 
        {
            return Entity.Null;
        }
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            UnityEngine.Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            float rayDistance = 100f;
            Debug.Log(Raycast(ray.origin, ray.direction * rayDistance));
        }
    }
}
