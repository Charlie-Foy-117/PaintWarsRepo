using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Lever : MonoBehaviour
{
    public bool leverOn = true;
    private bool buttonPressed = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (buttonPressed == true && leverOn == true)
            {
                LeverOff();
            }
            if (buttonPressed == true && leverOn == false)
            {
                LeverOn();
            }
        }
    }

    private void LeverOn()
    {
        leverOn = true;
    }

    private void LeverOff()
    {
        leverOn = false;
    }

    private void OnMouseDown()
    {
        buttonPressed = true;
    }
}
