using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Lever : MonoBehaviour
{
    [SerializeField]
    GameObject leverOn;

    [SerializeField]
    GameObject leverOff;

    public bool isOn = false;

    private void Start()
    {
        //set the lever to off sprite
        gameObject.GetComponent<SpriteRenderer>().sprite = leverOff.GetComponent<SpriteRenderer>().sprite;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //set the lever to on sprite
        gameObject.GetComponent<SpriteRenderer>().sprite = leverOn.GetComponent<SpriteRenderer>().sprite;

        //set the isOn to true when triggered
        isOn = true;
    }
}
