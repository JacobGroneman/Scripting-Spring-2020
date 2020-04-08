using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleHud : MonoBehaviour
{
    public Text nameText;
    public Text levelText;
    public Slider healthSlider;

    public void setHud(Unit unit)
    {
        nameText.text = unit.unitName;
        levelText.text = "Lvl " + unit.unitLevel;
        healthSlider.maxValue = unit.maxHp;
        healthSlider.value = unit.currentHp;
    }

    public void SetHP(int hp)
    {
        healthSlider.value = hp;
    }
}
