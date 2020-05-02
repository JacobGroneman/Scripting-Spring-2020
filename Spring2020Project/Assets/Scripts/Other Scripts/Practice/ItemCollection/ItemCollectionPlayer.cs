using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollectionPlayer : MonoBehaviour
{
    public List<GameObject> collectibles;
    private int _points;
    
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

    void LateUpdate()
    {
        
    }
}
