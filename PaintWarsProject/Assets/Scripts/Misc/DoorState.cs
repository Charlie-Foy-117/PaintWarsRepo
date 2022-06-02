using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorState : MonoBehaviour
{
    public int leverNeeded = 0;
    
    [SerializeField]
    GameObject doorUnlocked;

    [SerializeField]
    GameObject doorLocked;

    public void GetDoorState()
    {
        if (leverNeeded == GetComponent<GameManager>().noOfLeversFlipped)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = doorUnlocked.GetComponent<SpriteRenderer>().sprite;
        }
    }

   /* private void Update()
    {
        GetDoorState();
    }*/
}
