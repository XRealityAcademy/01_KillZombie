using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    // Get the HealthBar Slider
    public Slider slider;
    // Start is called before the first frame update
    
    // Set Max Health function
    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }
    
    // Set Slider value equal to the health value
    public void SetHealth(int health)
    {
        slider.value = health;
    }
}
