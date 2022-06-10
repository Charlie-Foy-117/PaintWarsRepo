using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue
{
    //sets the size of the text area
    [TextArea(3, 10)]
    //creates a string array of sentences
    // takes a string for name
    public string[] sentences;
    public string name;
}

