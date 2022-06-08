using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class First_BossJumpAttack : MonoBehaviour
{
    private Vector2 direction;
    public int jumpForce = 0;
    Rigidbody2D ourRigidbody2D;

    private void Awake()
    {
        ourRigidbody2D = GetComponent<Rigidbody2D>();
    }
    //runs command when boss hits ground
    private void OnCollisionEnter2D(Collision2D collision)
    {

        Debug.Log("Collision");
        //checks to make sure collision is with floor before running command
        if (collision.collider.CompareTag("Floor"))
        {
            //when boss hits ground command runs an boss jumps again
            ourRigidbody2D.AddForce(Vector2.up * jumpForce);
            Debug.Log("Compared Tag");
        }
    }
}
