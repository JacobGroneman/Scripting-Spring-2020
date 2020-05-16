using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class fsmAttack : StateClass
{
    private float _rotationSpeed = 02.0f;
    private AudioSource _shootAudio;
    
    public fsmAttack
        (GameObject _npc, NavMeshAgent _agent, Animator _anim, Transform _player) 
        : base(_npc, _agent, _anim, _player)
    {
        name = STATE.ATTACKING;
        _shootAudio = npc.GetComponent<AudioSource>();
    }

    public override void Enter()
    {
        anim.SetTrigger("isAttacking");
        agent.isStopped = true;
        _shootAudio.Play();
        base.Enter();
    }

    public override void Update()
    {
        base.Update();
    }

    public override void Exit()
    {
        base.Exit();
    }
}
