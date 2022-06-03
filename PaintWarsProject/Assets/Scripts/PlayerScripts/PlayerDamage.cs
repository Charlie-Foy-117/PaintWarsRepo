using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    [Header("Negative number for damage the hazard should deal")]
    //how much damage this hazard will deal
    public int playerDamage = 3;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //get the health componenet from the object
        EnemyHealth healthScript = collision.gameObject.GetComponent<EnemyHealth>();

        if (healthScript) //the thing we collided with has a health script
        {
            //we hit the player
            healthScript.ChangeHealth(playerDamage);
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
