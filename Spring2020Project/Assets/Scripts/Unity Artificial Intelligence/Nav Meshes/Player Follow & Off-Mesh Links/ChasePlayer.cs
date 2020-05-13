using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ChasePlayer : MonoBehaviour
{
    private GameObject _player;
    private NavMeshAgent _nmAg;

    void Start()
    {
        _player = GameObject.FindWithTag("Player");
        _nmAg = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        _nmAg.SetDestination(_player.transform.position);
    }
}
