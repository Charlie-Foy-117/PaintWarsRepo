using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float forceStrength; //how fast enemy moves
    public float stopDistance; //how close we get before mobing to next patrol point
    public Vector2[] patrolPoints; // list of patrol point we will go between
    private int currentPoint = 0; // index of the current point we're moving towards
    private Rigidbody2D ourRigidbody; //the rigid body attached to this object

    void Awake()
    {
        //get rigidbody we are using for movement
        ourRigidbody = GetComponent<Rigidbody2D>();
    }
    
    // Update is called once per frame
    void Update()
    {
        //how far awat are we from the target
        float distance = (patrolPoints[currentPoint] - (Vector2)transform.position).magnitude;

        //if we are closer to our target than our minimum distance...
        if (distance <= stopDistance)
        {
            //update the next target
            currentPoint = currentPoint + 1;

            //if weve gone past the end of our list..
            if (currentPoint >= patrolPoints.Length)
            {
                //loop back to start by setting the current point index to 0
                currentPoint = 0;
            }
        }

        //now move in the direction of our target
        //get direction
        //subtract the current position from the target position to get a distance vector
        //normalise changes it to be length 1, so we can then multiply it by our speed / force
        Vector2 direction = (patrolPoints[currentPoint] - (Vector2)transform.position).normalized;

        //move in the correct direciton with the set force strength
        ourRigidbody.AddForce(direction * forceStrength);
    }
}
