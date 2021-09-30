using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

interface iPlayer
{
    void mousehit();
}
public class Player : MonoBehaviour, iPlayer
{
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;
    void Start()
    {
        
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        
    }
    public void mousehit()
    {
       
    }

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
        Ray r = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(r, out hit))
        {
            if (hit.transform.tag == "Zombie")
            {
                Damage(10);
                Debug.Log("Hit Zombie");
            }
        }

    }
    
    //Mouse Click inside OnTriggerEnter
  /*  public void OnTriggerEnter(Collider col)

        if(Input.GetKeyDown(KeyCode.Mouse0))     
        {     
            Damage(10);
        }  
        
        Debug.Log("Damage");
        
    }*/
    
    public void Damage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
    
    
    
    
}



    

