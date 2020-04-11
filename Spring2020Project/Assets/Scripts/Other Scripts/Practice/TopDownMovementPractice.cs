using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovementPractice : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb2d;
    
    private Vector2 _movement;

    public Animator animator;

    void Update()
    {
        _movement.x = Input.GetAxisRaw("Horizontal");
        _movement.y = Input.GetAxisRaw("Vertical");
        
        animator.SetFloat("Horizontal", _movement.x);
        animator.SetFloat("Vertical", _movement.y);
        animator.SetFloat("Speed", _movement.sqrMagnitude);

       if (_movement.x == -1)
        {
            //Fix This Line
            this.gameObject.transform.localScale = new Vector3(-1, 0, 0);
        }
       else
       {
           this.gameObject.transform.localScale = new Vector3(1, 1, 1);
       }
    }

    private void FixedUpdate()
    {
        rb2d.MovePosition(rb2d.position + _movement * speed * Time.fixedDeltaTime);
    }
}
