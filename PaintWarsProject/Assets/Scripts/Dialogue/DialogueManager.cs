using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameText; //text variable
    public Text dialogueText;
    public Animator animate;
    private Queue<string> sentences;

    private void Start()
    {
        sentences = new Queue<string>();
    }

    public void PlayDialogue(Dialogue dialogue)
    {
        //when triggered box appears on screens and draws sentences
        animate.SetBool("OnScreen", true);

        nameText.text = dialogue.name;
        sentences.Clear();

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        NewSentence();
    }

    public void NewSentence()
    {
        //checks to see if all sentences have been drawn and end the text box on screen
        if (sentences.Count == 0)
        {
            End();

            return;
        }
        //calls to set box to draw new sentences
        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(DrawSentence(sentence));
    }

    IEnumerator DrawSentence(string sentence)
    {
        //draws sentence on screen
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }
    
    void End()
    {
        //ends text on screen
        animate.SetBool("OnScreen", false);
    }
}
