using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightController : MonoBehaviour
{
    public Slider slideSwitch;
    public bool theSwitch;
    public LightBulb[] lightBulbs = new LightBulb[5];
    public List<LightBulb> brightLightBulbs;
    void Start()
    {
        lightBulbs[0]._brand = LightBulb.Brand.BillsBlue;
        lightBulbs[1]._brand = LightBulb.Brand.RubyRidge;
        lightBulbs[2]._brand = LightBulb.Brand.CopperWorks;
        lightBulbs[3]._brand = LightBulb.Brand.Philips;
        lightBulbs[4]._brand = LightBulb.Brand.Oldes;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            //SearchQualityLighting();
        }
    }

    /*public void SearchQualityLighting()
    {
        foreach (var bulb in lightBulbs)
        {
            if(bulb.maxBrightness >= 50) 
            {
                brightLightBulbs.Add;
            }
        }
    }*/
}
