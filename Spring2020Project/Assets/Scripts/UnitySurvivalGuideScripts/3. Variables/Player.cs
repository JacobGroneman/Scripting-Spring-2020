using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string name = "Jacob";
    public int age = 21;
    public float speed = 41.5f;
    private float health = 93.2f;
    private int score = 195;
    private float speedStat = 41.5f;
    private bool collected = false;
    private int ammo = 0;
    
    void Start()
    {
        UnityEngine.Debug.Log("Name = " + name + "/ " + 
                              "Age = " + age + "/ " + "Speed = " +
                              speed + "/ "+ "Health = " + 
                              health+ "/ " + "Score = " + score+ "/ "
                              + "Speed Stat = " + speedStat+ "/ "
                              + "Collected = " + collected+ "/ "
                              + "Ammo = " + ammo+ "/ ");
    }

    
    void Update()
    {
        
    }
}
