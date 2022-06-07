using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameObject[] levers;

    [SerializeField]
    GameObject[] Stonedoor;

    [SerializeField]
    GameObject[] Woodendoor;

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
        for (int i = 0; i < Stonedoor.Length; i++)
        {
            if (Stonedoor[i] && noOfLeversFlipped >= Stonedoor[i].GetComponent<DoorState>().reqLevers)
            {
                Stonedoor[i].GetComponent<DoorState>().OpenDoor();
            }
        }
        for (int i = 0; i < Woodendoor.Length; i++)
        { 
            if (Woodendoor[i] && noOfLeversFlipped >= Woodendoor[i].GetComponent<DoorState>().reqLevers)
            {
                Woodendoor[i].GetComponent<DoorState>().OpenDoor();
            }
        }
    }
    private void Update()
    {
        GetNoOfLevers();
        GetDoorState();
    }

}
