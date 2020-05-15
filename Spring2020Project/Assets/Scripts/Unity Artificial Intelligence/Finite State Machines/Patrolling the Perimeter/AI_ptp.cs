using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI_ptp : MonoBehaviour
{
    private NavMeshAgent _agent;
    private Animator _anim;
    public Transform player;
    private StateClass _currentState;
    
    void Start()
    {
        _agent = this.GetComponent<NavMeshAgent>();
        _anim = this.GetComponent<Animator>();
        _currentState = new Idle(this.gameObject, _agent, _anim, player);
    }

    void Update()
    {
        _currentState = _currentState.Process();
    }
}
