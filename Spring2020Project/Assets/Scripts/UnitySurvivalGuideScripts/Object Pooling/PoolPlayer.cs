using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolPlayer : MonoBehaviour
{
    public GameObject bulletPrefab;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet = PoolPoolManager.Instance.RequestBullet();
            bullet.transform.position = Vector3.zero;
        }
    }
}
