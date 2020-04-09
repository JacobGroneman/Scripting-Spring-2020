using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Color = System.Drawing.Color;

public class LightBulb : MonoBehaviour
{
    private string _productName;
    private int _maxBrightness;
    private Color _color;

    public enum Brand
    {
        BillsBlue,
        RubyRidge,
        CopperWorks,
        Philips,
        Oldes
    }

    public Brand _brand;

    private void Update()
    {
        switch (_brand)
        {
            case Brand.BillsBlue:
                _productName = "Blaze LED";
                _maxBrightness = 100;
                _color = Color.Blue;
                break;
            case Brand.RubyRidge:
                _productName = "Heat Lamp Bulb";
                _maxBrightness = 50;
                _color = Color.Firebrick;
                break;
            case Brand.CopperWorks:
                _productName = "Robot LED";
                _maxBrightness = 34;
                _color = Color.Sienna;
                break;
            case Brand.Philips:
                _productName = "Boring White LED";
                _maxBrightness = 90;
                _color = Color.Azure;
                break;
            case Brand.Oldes:
                _productName = "Retro Collection";
                _maxBrightness = 67;
                _color = Color.LemonChiffon;
                break;
        }
    }
}
