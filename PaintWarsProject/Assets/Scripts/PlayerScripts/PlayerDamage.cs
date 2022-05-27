using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    //condition: when the projectile hits a certain object type (enemy)
    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        //check if the object we collided with has the tag we are looking for
        if (otherCollider.CompareTag("Enemy"))
        {
            //perform our action
            KillEnemy(otherCollider.gameObject);
            Destroy(gameObject);
        }
    }

    //action: Destory object
    public void KillEnemy(GameObject enemy)
    {
        Destroy(enemy);
    }
}
