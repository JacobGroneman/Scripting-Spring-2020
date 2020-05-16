using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrol : StateClass
{
    private int _currentIndex = -1;
    public Patrol
        (GameObject _npc, NavMeshAgent _agent, Animator _anim, Transform _player) 
        : base(_npc, _agent, _anim, _player)
    {
        name = STATE.PATROL;
        agent.speed = 2;
        agent.isStopped = false;
    }

    public override void Enter()
    {
                                                #region ReturnToNearestWaypoint
        
        float lastDistance = Mathf.Infinity;
        
        for (int i = 0; i < GameEnvironment.Singleton.Checkpoints.Count; i++)
        {
            GameObject thisWaypoint = GameEnvironment.Singleton.Checkpoints[i];
            float distance = Vector3.Distance
                (npc.transform.position, thisWaypoint.transform.position);

            if (distance < lastDistance)
            {
                _currentIndex = i - 1; //-1 corrects the Way-point Number when "_currentIndex++;" in Update()
                lastDistance = distance;
            }
        }
                                                #endregion
        
        anim.SetTrigger("isWalking");
        base.Enter();
    }

    public override void Update()
    {
        if (agent.remainingDistance < 1)
        {
            if (_currentIndex >= GameEnvironment.Singleton.Checkpoints.Count - 1) 
                _currentIndex = 0;
            else
                _currentIndex++;
            
            agent.SetDestination
                (GameEnvironment.Singleton
                .Checkpoints[_currentIndex].transform.position);
        }
        if (CanSeePlayer())
        {
            nextState = new Pursue(npc, agent, anim, player);
            stage = EVENT.EXIT;
        }
    }

    public override void Exit()
    {
        anim.ResetTrigger("isWalking");
        base.Exit();
    }
    
}
