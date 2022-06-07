using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int startingHealth = 3;
    private int currentHealth = 3;

    //calls Healthbarslider script
    public HealthBarSlider healthBar;
    PlayerHealthPotTotal totalHealthPots;
    private int usedHealthPot = 1;

    public float hitInvincibilityMaxTime = 1;
    private float lastHitTime = 0;

    private void Awake()
    {
        //initalising our current health to be equal to our starting health when the player spawns
        currentHealth = startingHealth;

        //sets healthbar slider value to starting health
        healthBar.SetMaxHealth(startingHealth);
    }
    //kill the player (for now delete gameobject)
    public void Kill()
    {
        //destroy the object this script is connected to
        Destroy(gameObject);
    }

    //change our current health by set amount
    public void ChangeHealth(int changeAmount)
    {
        //has it been long enough since we were last damaged
        if (Time.time >= lastHitTime + hitInvincibilityMaxTime)
        {
            //deal the damage
            currentHealth += changeAmount;

            //clamp health between 0 and starting health
            //to avoid negative health
            //and going above max health
            currentHealth = Mathf.Clamp(currentHealth, 0, startingHealth);

            if (currentHealth <= 0)
            {
                //preform kill action
                Kill();
            }
            //record when we were last hit
            lastHitTime = Time.time;
        }
    }

    public void HealPlayer()
    {
        if(currentHealth < 3 && PlayerHealthPotTotal.healthPotValue >= 1)
        {
            currentHealth++;
            totalHealthPots.AddHealthPotValue(usedHealthPot);
        }
        
    }
    private void Update()
    {
        //updates health bar value to equal currnet health value
        healthBar.SetHealth(currentHealth);
    }

}
