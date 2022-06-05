using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLineMovement : MonoBehaviour
{
    public float forceStrength;     // How fast we move
    public Vector2 direction;       // What direction the enemy should move in

    private Rigidbody2D ourRigidbody;   // The rigidbody attached to this object

    void Awake()
    {
        // Get the rigidbody that we'll be using for movement
        ourRigidbody = GetComponent<Rigidbody2D>();

        // Normalise our direction
        // Normalise changes it to be length 1, so we can later multiply it by our speed / force
        direction = direction.normalized;
    }

    void Update()
    {
        // Move in the correct direction with the set force strength
        ourRigidbody.AddForce(direction * forceStrength);
    }
}
