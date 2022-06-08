using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; //required when referring to the button component
using UnityEngine.EventSystems; //required when using event data


[RequireComponent(typeof(Button))]
public class PlayGame : MonoBehaviour
{
    //well store out button here so we can use it
    private Button button;

    //this fuction is called when the script first loads, before any start methods
    private void Awake()
    {
        //when the object first starts
        button = GetComponent<Button>();
    }

    public void LoadGame()
    {
        //loads first level
        SceneManager.LoadScene("Level 1");
    }

    public void Level1()
    {
        //loads first level
        SceneManager.LoadScene("Level 1");
    }

    public void Level2()
    {
        //loads second level from mapselection
        SceneManager.LoadScene("Level 2");
    }

    public void Level3()
    {
        //loads third level from mapselection
        SceneManager.LoadScene("Level 3");
    }

    public void Level4()
    {
        //loads fourth level from mapselection
        SceneManager.LoadScene("Level 4");
    }

    public void Level5()
    {
        //loads fifth level from mapselection
        SceneManager.LoadScene("Level 5");
    }

    public void BossLevel()
    {
        //loads boss level from mapselection
        SceneManager.LoadScene("Boss Level");
    }
}
