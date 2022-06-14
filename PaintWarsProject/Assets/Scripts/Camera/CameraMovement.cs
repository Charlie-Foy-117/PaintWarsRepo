using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    //declares object to be used as a target
    public Transform player;
    //sets delay when moving
    public float delayTime;
    //declares position variables that will be changed for cam
    public Vector3 cameraPosition;
    public Vector3 velocity = Vector3.zero;

    public float height = 0; //allows to fix camera height in unity 

    // Update is called once per frame
    void Update()
    {
        //sets the target location for camera to move to
        cameraPosition = new Vector3(player.position.x, player.position.y + height, -10f);
        //moves the camera if its not at the players location
        transform.position = Vector3.SmoothDamp(gameObject.transform.position, cameraPosition, ref velocity, delayTime);
    }
}
