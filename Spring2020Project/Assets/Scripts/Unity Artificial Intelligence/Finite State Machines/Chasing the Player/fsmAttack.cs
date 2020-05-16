using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
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
        Vector3 direction = player.position - npc.transform.position;
        float angle = Vector3.Angle(direction, npc.transform.forward);
        direction.y = 0; //Prevents Tilting
       
        npc.transform.rotation = Quaternion.Slerp
            (npc.transform.rotation, Quaternion.LookRotation(direction), 
            _rotationSpeed * Time.deltaTime);

        if (!CanAttackPlayer())
        {
            nextState = new Idle(npc, agent, anim, player);
            stage = EVENT.EXIT;
        }
    }

    public override void Exit()
    {
        anim.ResetTrigger("isAttacking");
        _shootAudio.Stop();
        base.Exit();
    }
}
