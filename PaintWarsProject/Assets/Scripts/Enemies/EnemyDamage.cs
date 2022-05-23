using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [Header("Negative number for damage the hazard should deal")]
    //how much damage this hazard will deal
    [Tooltip("Negative number for damage the hazard should deal")]
    public int enemyDamage = 1;
    private void OnCollisionStay2D(Collision2D collision)
    {
        //get the health componenet from the object
        PlayerHealth healthScript = collision.gameObject.GetComponent<PlayerHealth>();
        //when our enemy object collides with the player...
        if (healthScript) //the thing we collided with has a health script
        {
            //we hit the player
            healthScript.ChangeHealth(enemyDamage);

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
