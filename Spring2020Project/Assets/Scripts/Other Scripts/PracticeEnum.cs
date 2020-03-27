using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeEnum : MonoBehaviour
{
    public enum PlayerBehaviors
    {
        Standing,
        Walking,
        Running,
        Nauseous
    }

    public PlayerBehaviors currentPlayerState;
    
    void Update()
    {
        switch (currentPlayerState)
        {
            case PlayerBehaviors.Standing:
                this.gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
                Debug.Log("Your player is standing");
                break;
            
            case PlayerBehaviors.Walking:
                this.gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
                Debug.Log("Your player is walking");
                break;
            
            case PlayerBehaviors.Running:
                this.gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
                Debug.Log("Your player is running");
                break;
            
            case PlayerBehaviors.Nauseous:
                this.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                Debug.Log("Your player is green");
                break;
        }
    }
}
