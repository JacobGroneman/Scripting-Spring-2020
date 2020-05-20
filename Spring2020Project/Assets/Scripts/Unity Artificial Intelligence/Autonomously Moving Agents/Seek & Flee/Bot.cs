using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Bot : MonoBehaviour
{
    private NavMeshAgent _agent;

    private bool _activateSeek = false;
    private bool _activateFlee = false;

    public GameObject target;

    void Start()
    {
        _agent = this.GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        Seek(target.transform.position);

        if (Input.GetKeyDown(KeyCode.Q))
        {
            _activateSeek = true;
            _activateFlee = false;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            _activateSeek = false;
            _activateFlee = true;
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            _activateSeek = false;
            _activateSeek = false;
        }

        do
        {
            Seek(this.transform.position);
        } while (_activateSeek);

        do
        {
            Flee(this.transform.position);
        } while (_activateFlee);
    }

    private void Seek(Vector3 playerLocation)
    {
        _agent.SetDestination(playerLocation);
    }

    private void Flee(Vector3 playerLocation)
    {
        Vector3 fleeVector = playerLocation - this.transform.position;
        _agent.SetDestination(this.transform.position - fleeVector);
    }
}
