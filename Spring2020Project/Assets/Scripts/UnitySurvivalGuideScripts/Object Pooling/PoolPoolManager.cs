using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolPoolManager : MonoSingleton<PoolPoolManager>
{
    [SerializeField]
    private GameObject _bullets;
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
    

}
