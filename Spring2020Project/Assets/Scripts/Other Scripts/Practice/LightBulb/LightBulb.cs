using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Color = System.Drawing.Color;

public class LightBulb : MonoBehaviour
{
    public string productName;
    public int maxBrightness;
    public Color color;

    private enum Brand
    {
        BillsBlue,
        RubyRidge,
        CopperWorks,
        Philips,
        Oldes
    }

    private Brand _brand;

    private void Update()
    {
        switch (_brand)
        {
            case Brand.BillsBlue:
                productName = "Blaze LED";
                maxBrightness = 100;
                color = Color.Blue;
                break;
            case Brand.RubyRidge:
                productName = "Heat Lamp Bulb";
                maxBrightness = 50;
                color = Color.Firebrick;
                break;
            case Brand.CopperWorks:
                productName = "Robot LED";
                maxBrightness = 34;
                color = Color.Sienna;
                break;
            case Brand.Philips:
                productName = "Boring White LED";
                maxBrightness = 90;
                color = Color.Azure;
                break;
            case Brand.Oldes:
                productName = "Retro Collection";
                maxBrightness = 67;
                color = Color.LemonChiffon;
                break;
        }
    }
}
