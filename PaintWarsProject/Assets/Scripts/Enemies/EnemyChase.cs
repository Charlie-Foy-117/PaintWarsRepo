using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    public float forceStrength; // How fast we move
    public Transform target; // The thing you want to chase

    private Vector2 direction;
    private Rigidbody2D ourRigidbody;

    void Awake()
    {
        // Get the rigidbody that we'll be using for movement
        ourRigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Move in the direction of our target

        // Get the direction
        // Subtract the current position from the target position to get a distance vector
        // Normalise changes it to be length 1, so we can then multiply it by our speed / force
        direction = new Vector2(target.position.x - transform.position.x, transform.position.y);

        // Move in the correct direction with the set force strength
        ourRigidbody.AddForce(direction * forceStrength);
    }
}
