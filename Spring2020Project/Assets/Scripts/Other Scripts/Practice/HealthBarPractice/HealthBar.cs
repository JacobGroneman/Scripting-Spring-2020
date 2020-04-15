using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image fill;
    public Gradient colorLevels;
    public Slider slider;

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;

        fill.color = colorLevels.Evaluate(1f);
    }

    public void SetHealth(int health)
    {
        slider.value = health;

        fill.color =
            colorLevels.Evaluate(slider.normalizedValue);
    }

    public void SetCurrentHealth(int currentHealth)
    {
       slider.value = currentHealth;
    }
}
