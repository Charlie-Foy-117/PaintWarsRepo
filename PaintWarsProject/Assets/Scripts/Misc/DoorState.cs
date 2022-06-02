using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorState : MonoBehaviour
{
    public int leversNeeded = 2;
    
    [SerializeField]
    GameObject doorUnlocked;

    [SerializeField]
    GameObject doorLocked;

    private void Start()
    {
        //set the lever to off sprite
        gameObject.GetComponent<SpriteRenderer>().sprite = doorLocked.GetComponent<SpriteRenderer>().sprite;
    }
    public void GetDoorState()
    {
        if (leversNeeded == gameObject.GetComponent<GameManager>().noOfLeversFlipped)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = doorUnlocked.GetComponent<SpriteRenderer>().sprite;
        }
    }

   /* void Update()
    {
        GetDoorState();
    } */
}
