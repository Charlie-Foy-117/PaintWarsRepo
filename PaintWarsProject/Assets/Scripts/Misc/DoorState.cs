using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorState : MonoBehaviour
{
    Animator animate;

    [SerializeField]
    GameObject DoorType;

    int stateOfDoor = 1;
    public int reqLevers = 0;

    private void Start()
    {
        //initialise the animator
        animate = GetComponent<Animator>();

        //set doors to closed
        if (DoorType.tag == "Stonedoor")
        {
            ClosedDoor();
        }

        if (DoorType.tag == "Woodendoor")
        {
            ClosedDoor();
        }
    }

    //fuction to close door and set its state
    void ClosedDoor()
    {
        if (DoorType.tag == "Stonedoor")
        {
            animate.SetFloat("DoorState", 1);
            stateOfDoor = 1;
        }
        if (DoorType.tag == "Woodendoor")
        {
            animate.SetFloat("DoorState", 1);
            stateOfDoor = 1;
        }
    }

    //fuction to open door and set its state
    public void OpenDoor()
    {
        reqLevers = 0;

        if (DoorType.tag == "Stonedoor")
        {
            animate.SetFloat("DoorState", 2);
            stateOfDoor = 2;
            Destroy(gameObject.GetComponent<EdgeCollider2D>());
        }
        if (DoorType.tag == "Woodendoor")
        {
            animate.SetFloat("DoorState", 2);
            stateOfDoor = 2;
            Destroy(gameObject.GetComponent<EdgeCollider2D>());
        }
    }

    //fuction to set the state of the door
    public void SetDoorState(int state)
    {
        if (state == 1 && DoorType.tag == "StoneDoor")
        {
            ClosedDoor();
        }
        if (state == 2 && DoorType.tag == "StoneDoor")
        {
            OpenDoor();
        }

        if (state == 1 && DoorType.tag == "Woodendoor")
        {
            ClosedDoor();
        }
        if (state == 2 && DoorType.tag == "Woodendoor")
        {
            OpenDoor();
        }
    }
    
    //fuction to get the current door state
    public int GetDoorState()
    {
        return stateOfDoor;
    }
}
