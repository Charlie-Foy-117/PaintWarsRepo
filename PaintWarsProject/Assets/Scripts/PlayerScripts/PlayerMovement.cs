using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //public variable, visible in unity inspector
    public float moveSpeed = 3.0f;
    private Animator animate;

    private Rigidbody2D physicsBody = null;
    // Start is called before the first frame update
    void Start()
    {
        physicsBody = GetComponent<Rigidbody2D>();
        animate = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //ask unitys input manager for the current value of the hor axis this will be between -1 and 1
        float axisValX = Input.GetAxis("Horizontal");
        float axisValY = Input.GetAxis("Vertical");
       
        //use axes value to set up a new velocity vector
        Vector2 newVel = new Vector2(axisValX, axisValY);

        //scale our velocity based on speed
        //goes from -speed to +speed
        newVel = newVel * moveSpeed;

        //sets "run" float to 0 when not moving
        animate.SetFloat("run", 0);

    }

    public void MoveLeft()
    {
        Debug.Log("Left button pressed");

        Vector2 newVel = new Vector2(-moveSpeed, 0);

        physicsBody.velocity = newVel;

        //allows idle animation to change into run animation when moving
        animate.SetFloat("run", 1);
    }

    public void MoveRight()
    {
        Debug.Log("Right button pressed");

        Vector2 newVel = new Vector2(moveSpeed, 0);

        physicsBody.velocity = newVel;

        //allows idle animation to change into run animation when moving
        animate.SetFloat("run", 1);
    }

}
