using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownPlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Animator animator;
    
    private Vector2 _movement;
    
    void Update()
    {
        _movement.x = Input.GetAxisRaw("Horizontal");
        _movement.y = Input.GetAxisRaw("Vertical");
        
        animator.SetFloat("Horizontal", _movement.x);
        animator.SetFloat("Vertical", _movement.y);
        animator.SetFloat("Speed", _movement.sqrMagnitude);

        if (_movement.x == -1)
        {
            this.gameObject.transform.localScale = new Vector3(-1, 0, 0);
        }
        else
        {
            this.gameObject.transform.position = new Vector3(1, 1, 1);
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + Time.fixedDeltaTime * moveSpeed * _movement);
    }
}

