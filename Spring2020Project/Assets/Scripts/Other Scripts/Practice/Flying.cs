using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Flying : StateClass
{
    public Flying
        (GameObject _npc, NavMeshAgent _agent, Animator _anim, Transform _player)
        : base(_npc, _agent, _anim, _player)
    {
        //name = STATE.FLYING;
        agent.speed = 10.0f;
        agent.isStopped = false;
    }

    public override void Enter()
    {
        anim.SetTrigger("isFlying");
        base.Enter();
    }

    public override void Update()
    {
        agent.acceleration = 02.0f;
        
        Vector3 flyingDestination = Vector3.up;
        agent.SetDestination(flyingDestination);

        if (!CanSeePlayer())
        {
            //nextState = new Fall(npc, agent, anim, player);
            stage = EVENT.EXIT;
        }
    }

    public override void Exit()
    {
        anim.ResetTrigger("isFlying");
        base.Exit();
    }
}

