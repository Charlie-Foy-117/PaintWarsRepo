using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int startingHealth = 1;
    private int currentHealth = 1;

    public float hitInvincibilityMaxTime = 1;
    private float lastHitTime = 0;

    [SerializeField]
    GameObject healthPotDrop;

    [SerializeField]
    GameObject bossDrop;

    private void Awake()
    {
        //initalising our current health to be equal to our starting health when the player spawns
        currentHealth = startingHealth;
    }
    //kill the player (for now delete gameobject)
    public void Kill()
    {
        //destroy the object this script is connected to
        Destroy(gameObject);
        if (gameObject.CompareTag("Boss"))
        {
            Instantiate(bossDrop, transform.position, Quaternion.identity);
        }
        else
        {
            Instantiate(healthPotDrop, transform.position, Quaternion.identity);
        }
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
}
