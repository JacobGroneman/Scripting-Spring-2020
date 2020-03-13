using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolPoolManager : MonoSingleton<PoolPoolManager>
{
    [SerializeField]
    private Transform _bullets;
    [SerializeField]
    private GameObject _bulletprefab;
    [SerializeField]
    private List<GameObject> _bulletPool;

    private void Start()
    {
        _bulletPool = GenerateBullets(10);
    }

    List<GameObject> GenerateBullets(int limit)
    {
        for (int i = 0; i < limit; i++)
        {
            GameObject bullet = Instantiate(_bulletprefab, _bullets.transform, true);
            bullet.SetActive(false);
            _bulletPool.Add(bullet);
        }
        return _bulletPool;
    }

    public GameObject RequestBullet()
    {
        foreach (var bullet in _bulletPool)
        {
            if (bullet.activeInHierarchy == false)
            {
                bullet.SetActive(true);
                return bullet;
            }
        }

        GameObject newBullet = Instantiate(_bulletprefab, _bullets, true);
        newBullet.SetActive(true);
        _bulletPool.Add(newBullet);
        return newBullet;
    }

}
