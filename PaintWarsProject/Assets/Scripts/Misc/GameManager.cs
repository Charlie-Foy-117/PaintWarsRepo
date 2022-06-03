using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameObject[] levers;

    [SerializeField]
    GameObject door;

    public int noOfLeversFlipped = 0;

    void Start()
    {
        GetNoOfLevers();
    }

    public int GetNoOfLevers()
    {
        for (int i = 0; i < levers.Length; i++)
        {
            if(levers[i].GetComponent<Lever>().isOn == true)
            {
                noOfLeversFlipped++;
                levers[i].GetComponent<Lever>().isOn = false;
            }
        }

        return noOfLeversFlipped;
    }

    public void GetDoorState()
    {
        if (noOfLeversFlipped == 2)
        {
            door.GetComponent<DoorState>().OpenDoor();
        }
    }
    private void Update()
    {
        GetNoOfLevers();
        GetDoorState();
    }

}
