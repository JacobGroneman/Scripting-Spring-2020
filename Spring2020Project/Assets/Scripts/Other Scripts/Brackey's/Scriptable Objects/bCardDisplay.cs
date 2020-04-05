using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bCardDisplay : MonoBehaviour
{
    public bCard card;

    public Text 
        nameUI, descriptionUI, manaCostUI, attackUI, healthUI;

    public Image artUI;

    private void Start()
    {
        card.PrintCardInfoToLog();
        
        nameUI.text = card.name;
        descriptionUI.text = card.description;

        manaCostUI.text = card.mannaCost.ToString();
        attackUI.text = card.attack.ToString();
        healthUI.text = card.health.ToString();
        
        card.artwork = artUI.sprite;
    }
}
