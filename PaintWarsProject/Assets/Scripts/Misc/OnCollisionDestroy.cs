using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionDestroy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider)
        {
            ProjectileCollision();
        }
    }
    public void ProjectileCollision()
    {
        Destroy(gameObject);
    }
}
