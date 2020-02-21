using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Color = System.Drawing.Color;

public class MyOwnEnumCycle : MonoBehaviour
{
    public GameObject colorBall;
    
   public enum ColorCycle
   {
       Red, Orange, Yellow, Green, Blue, Purple
   }
   
   public ColorCycle currentColor;

   void Start()
   {
       currentColor = ColorCycle.Red;
       colorBall = GameObject.Find("Color Ball");
   }

   
    void Update()
    {
        switch (currentColor)
        {
            case ColorCycle.Red:
                GetColor(UnityEngine.Color.red);
                ChangeColor(ColorCycle.Orange);
                break;
            case ColorCycle.Orange:
                GetColor(new UnityEngine.Color(255, 127, 80));
                ChangeColor(ColorCycle.Yellow);
                break;
            case ColorCycle.Yellow:
                GetColor(UnityEngine.Color.yellow);
                ChangeColor(ColorCycle.Green);
                break;
            case ColorCycle.Green:
                GetColor(UnityEngine.Color.green);
                ChangeColor(ColorCycle.Blue);
                break;
            case ColorCycle.Blue:
                GetColor(UnityEngine.Color.blue);
                ChangeColor(ColorCycle.Purple);
                break;
            case ColorCycle.Purple:
                GetColor(UnityEngine.Color.magenta);
                ChangeColor(ColorCycle.Red);
                break;
        }
    }

    public void GetColor(UnityEngine.Color aColor)
    {
        colorBall.GetComponent<MeshRenderer>().material.color = aColor;
    }
    public void ChangeColor(ColorCycle colorToChange)
    {
        if (Time.time > 1)
        {
            currentColor = colorToChange;
        }
    }
}
