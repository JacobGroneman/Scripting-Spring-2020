using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
   public enum EnemyState
   {
       Patrolling,
       Attacking,
       Chasing,
       Death
   }

   public EnemyState currentState;
   
   void Start()
   {
       currentState = EnemyState.Patrolling;
   }
   
   void Update()
    {
        switch (currentState)
        {
            case EnemyState.Patrolling:
                UnityEngine.Debug.Log("Patrolling");
                if (Time.time > 5) //very clever!
                {
                    currentState = EnemyState.Chasing;
                }
                break;
            case  EnemyState.Attacking:
                UnityEngine.Debug.Log("Attacking");
                break;
            case EnemyState.Chasing:
                UnityEngine.Debug.Log("Chasing");
                break;
            case  EnemyState.Death:
                UnityEngine.Debug.Log("Dying");
                break;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentState = EnemyState.Death;
        }
    }
}
