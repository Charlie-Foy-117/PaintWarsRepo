using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    //public variable, visible in unity inspector
    public float jumpSpeed = 3.0f;
    public bool inAir = true;
    Animator animate;

    private Rigidbody2D physicsBody = null;

    public float interval = 0;


    // Start is called before the first frame update
    void Start()
    {
        animate = GetComponent<Animator>();
        physicsBody = GetComponent<Rigidbody2D>();
    }
    public void StartJump()
    {
        StartCoroutine(JumpAnimation(interval));
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
        newVel = newVel * jumpSpeed;
    }

    public void MoveUp()
    {
        if (!inAir)
        {
            Debug.Log("Jump button pressed");

            Vector2 newVel = new Vector2(0, jumpSpeed);

            physicsBody.velocity = newVel;

            inAir = true;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider)
        {
            inAir = false;
        }
    }

    IEnumerator JumpAnimation(float time)
    {
        animate.SetFloat("jump", 1);
        yield return new WaitForSeconds(time);
        MoveUp();
        animate.SetFloat("jump", 0);
    }
}
