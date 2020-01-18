using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string itemName;
    public string itemDescription;
    public Sprite itemSprite;
    public float attack;
    
    void Start()
    {
        UnityEngine.Debug.Log("Item: " + itemName);
        UnityEngine.Debug.Log("Description: " + itemDescription);
        UnityEngine.Debug.Log("Sprite: " + itemSprite);
        UnityEngine.Debug.Log("Attack: " + attack);
    }
    
}
