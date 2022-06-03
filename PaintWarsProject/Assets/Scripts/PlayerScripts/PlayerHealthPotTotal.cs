using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthPotTotal : MonoBehaviour
{
    public static int healthPotValue = 0;
    public Text healthPotDisplay;

    public void AddHealthPotValue(int toAdd)
    {
        healthPotValue += toAdd;

        healthPotDisplay.text = healthPotValue.ToString();
    }
    // Start is called before the first frame update
    void Start()
    {
        healthPotDisplay.text = healthPotValue.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
