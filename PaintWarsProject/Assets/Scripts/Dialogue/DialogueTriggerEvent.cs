using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTriggerEvent : MonoBehaviour
{
    public Dialogue dialogue;
    
    //runs StartDialogue() when trigger is active and deletes trigger box to stop repetition
    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartDialogue();
        Destroy(this);
    }

    //looks for dialogue script and runs the code
    public void StartDialogue()
    {
        FindObjectOfType<DialogueManager>().PlayDialogue(dialogue);
    }
}
