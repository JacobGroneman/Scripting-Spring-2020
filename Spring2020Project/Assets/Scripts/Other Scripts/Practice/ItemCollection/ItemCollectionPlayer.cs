using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollectionPlayer : MonoBehaviour
{
    public List<GameObject> collectibles;
    private int _points;

    public Animator animator;
    private Vector2 _movement;
    public Rigidbody2D rigidbody;
    private float moveSpeed = 10f;
    
    void Start()
    {
        PlayerUIManager.Instance.points.text = _points.ToString();
        PlayerUIManager.Instance.itemCount.text = collectibles.Count.ToString();
    }
    
    void OnColliderEnter(Collider col)
    {
        if (col.gameObject.tag == "point")
        {
            _points++;
            PlayerUIManager.Instance.points.text = _points.ToString();
        }

        if (col.gameObject.tag == "Collectible")
        {
           
           PlayerUIManager.Instance.itemCount.text = collectibles.Count.ToString();
        }
    }

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

    void LateUpdate()
    {
        rigidbody.MovePosition(rigidbody.position + Time.fixedDeltaTime * moveSpeed * _movement);
    }
}
