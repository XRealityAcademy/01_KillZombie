using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zombie_D : MonoBehaviour
{
    //Set MaxHealth
    public int maxHealth = 100;
    // Set Current Health
    public int currentHealth;
    // Get the HealthBar Script
    public HealthBar_D healthBar;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            isMouseHit();
        }

        if (healthBar.slider.value == 0)
        {
            Destroy(gameObject);
        }
    }

    public void isMouseHit()
    {
        // get a ray called "r", put the mousePosition to the camera as the ray direction
        Ray r = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;
        // check out if the raycast hit a tag called "Zombie"
        if (Physics.Raycast(r, out hit))
        {
            if (hit.transform.tag == "Zombie")
            {
                Damage(10);
                Debug.Log("Hit Zombie");
            }
        }
    }

    public void Damage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
}
