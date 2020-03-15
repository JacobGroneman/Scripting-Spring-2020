using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager2 : MonoBehaviour
{
   //Include a Singleton
   private static PoolManager2 _instance;

   public static PoolManager2 Instance
   {
      get
      {
         if (_instance == null)
         {
            Debug.Log("The Pool Manager is NULL");
         }

         return _instance;
      }
   }
   
   //Declare objects, object's storage, and the object's list.
   [SerializeField]
   private GameObject _bombPrefab;
   [SerializeField]
   private GameObject _bombs;
   [SerializeField]
   private List<GameObject> _bombPool;

   private void Start()
   {
      //Assign the Pool to the Function, returning inactive instantiated bomb(s).
      _bombPool = GenerateBombs(10);
      _instance = this;
   }

   /*Sets up a number of _bulletPrefabs in the GameWorld under the _bombs Parent Object,
   sets them false (so they are not active), and adds them to the Pool List so they
   Can be requested through the Method: Request Bullet*/
   private List<GameObject> GenerateBombs(int limit)
   {
      for (int i = 0; i < limit; i++)
      {
         GameObject bomb = Instantiate(_bombPrefab, _bombs.transform, true);
         bomb.SetActive(false);
         _bombPool.Add(bomb);
      }
      return _bombPool;
   }

   /*Operation for the Player to Requests the bomb(s) set in GenerateBombs from Start(),
   and set them to Active. This method includes operations for Additional Bombs to be
   Added.*/
   public GameObject RequestBomb()
   {
      foreach (var bomb in _bombPool)
      {
         if (bomb.activeInHierarchy == false)
         {
            bomb.SetActive(true);
            return bomb;
         }
      }
      GameObject newBomb = Instantiate(_bombPrefab, _bombs.transform, true);
      newBomb.SetActive(true);
      _bombPool.Add(newBomb);
      return newBomb;
   }
}
