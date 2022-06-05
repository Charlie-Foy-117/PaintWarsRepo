using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; //required when referring to the button component
using UnityEngine.EventSystems; //required when using event data

[RequireComponent(typeof(Button))]
public class ReturnToMenu : MonoBehaviour
{
    //well store out button here so we can use it
    private Button button;

    //this fuction is called when the script first loads, before any start methods
    private void Awake()
    {
        //when the object first starts
        button = GetComponent<Button>();
    }

    public void LoadMenu()
    {//loads menu
        SceneManager.LoadScene("Menu");
    }
}
