using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Random;
using Random = System.Random;

public class Mainpmp : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit _hitInfo;

            if (Physics.Raycast(rayOrigin, out _hitInfo))
            {
                IDamagable damagableObj = _hitInfo.collider.GetComponent<IDamagable>();
                
                if (damagableObj != null)
                {
                    int randomDamageAmount = UnityEngine.Random.Range(0, 100);
                    damagableObj.Damage(randomDamageAmount);
                }
            }
        }
        
    }
}
