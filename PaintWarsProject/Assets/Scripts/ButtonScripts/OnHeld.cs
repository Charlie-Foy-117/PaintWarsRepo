using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //required when referring to the button component
using UnityEngine.EventSystems; //required when using event data

//this line means that this script can only be attached to a gameobject that has a button component on it
[RequireComponent(typeof(Button))]
//the additional things in this list (IPointerDownHandler etc) let us repsond to more mouse/touch events happeneing to this object

public class OnHeld : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerExitHandler
{
    //well store out button here so we can use it
    private Button button;

    //well keep track of whether or not the button is pressed here
    private bool buttonPressed = false;
    
    //this fuction is called when the script first loads, before any start methods
    private void Awake()
    {
        //when the object first starts
        button = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        //if the button is currently being pressed
        if (buttonPressed)
        {
            //consider the button clicked and call the fuction linked on the button component
            button.onClick?.Invoke();
        }
    }

    //this fuction is called when the buton is clicked by the mouse or a touch
    public void OnPointerDown(PointerEventData eventData)
    {
        //ingore if button no interactable
        if (!button.interactable)
            return;

        //set the button as pressed
        buttonPressed = true;
    }

    //this fuction is called when the mouse or touch is released
    public void OnPointerUp(PointerEventData eventData)
    {
        //set the button as not pressed
        buttonPressed = false;
    }

    //this fuction is called when the mouse or touch move off the button
    public void OnPointerExit(PointerEventData eventData)
    {
        //set the button as not pressed
        buttonPressed = false;
    }
}
