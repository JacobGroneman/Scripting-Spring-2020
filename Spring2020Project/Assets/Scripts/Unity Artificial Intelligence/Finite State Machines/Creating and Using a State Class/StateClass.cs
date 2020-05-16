using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StateClass : MonoBehaviour
{
    public enum STATE
    {IDLE, PATROL, PURSUE, ATTACKING, ASLEEP};

    public enum EVENT
    {ENTER, UPDATE, EXIT};

    public STATE name;
    protected EVENT stage;
    protected GameObject npc;
    protected NavMeshAgent agent;
    protected Animator anim;
    protected Transform player;
    protected StateClass nextState;

    private float _visibleDistance = 10.0f;
    private float _visibleAngle = 30.0f;
    private float _shootDistance = 7.0f;

    public StateClass(GameObject _npc, NavMeshAgent _agent, Animator _anim, Transform _player)
    {
        npc = _npc;
        agent = _agent;
        anim = _anim;
        stage = EVENT.ENTER;
        player = _player;
    }

    public virtual void Enter() {stage = EVENT.UPDATE;}
    public virtual void Update() {stage = EVENT.UPDATE;}
    public virtual void Exit() {stage = EVENT.EXIT;}

    public StateClass Process()
    {
        if (stage == EVENT.ENTER) Enter();
        if (stage == EVENT.UPDATE) Update();
        if (stage == EVENT.EXIT)
        {
            Exit();
            return nextState;
        }
        return this;
    }

    public bool CanSeePlayer()
    {
        Vector3 direction = player.position - npc.transform.position;
        float angle = Vector3.Angle(direction, npc.transform.forward);
        
        if (direction.magnitude < this._visibleDistance && angle < _visibleAngle)
        {
            return true;
        }
        return false;
    }

    public bool CanAttackPlayer()
    {
        Vector3 direction = player.position - npc.transform.position;
        
        if (direction.magnitude < _shootDistance)
        {
            return true;
        }
        return false;
    }
}
