using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeEnum : MonoBehaviour
{
    private float speed = 0;
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
                TransformSpeed(0f);
                Debug.Log("Your player is standing");
                break;
            
            case PlayerBehaviors.Walking:
                this.gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
                TransformSpeed(.1f);
                Debug.Log("Your player is walking");
                break;
            
            case PlayerBehaviors.Running:
                this.gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
                TransformSpeed(.5f);
                Debug.Log("Your player is running");
                break;
            
            case PlayerBehaviors.Nauseous:
                this.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                TransformSpeed(0f);
                Debug.Log("Your player is green");
                break;
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            Time.timeScale = 0.5f;
        }
    }

    //I have to make this better.
    public void TransformSpeed(float theSpeed)
    {
        speed = theSpeed;
        for (int i = 0; i < 10000; i++)
        {
            transform.position = Time.deltaTime * speed * new Vector3(i, 0, 0);
        }
    }
}
