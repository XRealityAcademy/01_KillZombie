using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    //Set MaxHealth
    public int maxHealth = 100;
    // Set Current Health
    public int currentHealth;
    // Get the HealthBar Script
    public HealthBar healthBar;
    void Start()
    {
        // set the current health = maxHealth
        currentHealth = maxHealth;
        // set the health bar's value equals to the max health
        healthBar.SetMaxHealth(maxHealth);
        
    }


    void Update()
    {
        // if click the mouse, execute isMouseHit()
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            isMouseHit();
        }
        // if the health bar slider vale = 0, destroy gameObject(self) 
        if (healthBar.slider.value == 0)
        {
            Destroy(gameObject);
        }
            
    }
    // Damage function -> put an int as the damage, once the Damage function gets called, it will reduce 10 for the current Health. 
    // SetHealth to the current Health
    public void Damage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    public void isMouseHit()
    {
        // get a ray call "r", put the mousePosition to the camera as the ray direction
        Ray r = Camera.main.ScreenPointToRay(Input.mousePosition);
        //create a RaycastHit call "hit"
        RaycastHit hit;
        // check out if the Raycast hit a tag called "Zombie"
        if (Physics.Raycast(r, out hit))
        {
            //if the ray hit an object called Zombie, give it a damage 10, and write "Hit Zombie" in console
            if (hit.transform.tag == "Zombie")
            {
                Damage(10);
                Debug.Log("Hit Zombie");
            }
        }

    }

    
    
    
    
    
}



    

