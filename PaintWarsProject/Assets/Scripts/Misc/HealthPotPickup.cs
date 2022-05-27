using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotPickup : MonoBehaviour
{
    public int pickupValue = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerHealthPotTotal healthPotTotalScript = collision.GetComponent<PlayerHealthPotTotal>();

        if (healthPotTotalScript != null)
        {
            healthPotTotalScript.AddHealthPotValue(pickupValue);

            Destroy(gameObject);
        }    
    }
}
