using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBombThrow : MonoBehaviour
{
    //unity editor variables
    public GameObject projectilePrefab;
    public Vector2 projectileVelocity;
    private Vector3 offset;
    private int direction;

    public void ThrowProjectile()
    {
        offset = new Vector3(transform.position.x + 2, (float)(transform.position.y + 0.45), transform.position.z);
        //clone the projectile 
        //delcare a variable to hold the cloned object
        GameObject clonedProjectile;
        //use instantiate to clone the projectile and keep the result in our variable
        clonedProjectile = Instantiate(projectilePrefab);
        if (transform.localScale.x > 0)
        {
            offset = new Vector3((float)(transform.position.x + 1.5), (float)(transform.position.y + 1.5), transform.position.z);
        }
        if (transform.localScale.x < 0)
        {
            offset = new Vector3((float)(transform.position.x - 1.5), (float)(transform.position.y + 1.5), transform.position.z);
        }
        //position the projectile on the player
        clonedProjectile.transform.position = offset; //optional: add an offset (use a public variable)

        //fire it in a direction
        //declare a variable to hold the cloned object's rigidbody
        Rigidbody2D projectileRigidbody;
        //get the rigidbody from our projectile and store it
        projectileRigidbody = clonedProjectile.GetComponent<Rigidbody2D>();

        if (transform.localScale.x > 0)
        {
            direction = 1;
        }
        if (transform.localScale.x < 0)
        {
            direction = -1;
        }
        //set the velocity on the rigidbody to the editor setting
        projectileRigidbody.velocity = projectileVelocity * direction;
    }
}
