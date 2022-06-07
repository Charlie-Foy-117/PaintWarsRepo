using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class First_BossJumpAttack : MonoBehaviour
{
    private Vector2 direction;
    //runs command when boss hits ground
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //checks to make sure collision is with floor before running command
        if (collision.otherCollider.CompareTag("Floor"))
        {
            //when boss hits ground command runs an boss jumps again
            direction = new Vector2(transform.position.x, transform.position.y + 10);
        }
    }
}
