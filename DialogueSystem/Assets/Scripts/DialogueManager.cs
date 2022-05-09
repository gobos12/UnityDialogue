using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    //objects connected to dialogue UI
    public GameObject dialogueCanvas;
    public Text nameText;
    public Text dialogueText;

    //actual dialogue & reponse buttons
    private Queue<string> sentences;
    private Button[] buttons;

    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue d)
    {
        dialogueCanvas.SetActive(true); //activates dialogue canvas
        nameText.text = d.name; //sets name of gameobject

        sentences.Clear(); //clears any strings already in the queue

        foreach(string s in d.sentences){
            sentences.Enqueue(s);
        }

        DisplayNextSentence();
    }

    //pops next sentence every time this method is called
    public void DisplayNextSentence()
    {
        //if queue is empty...
        if(sentences.Count == 0){
            EndDialogue();
            return;
        }
        else{
            string sentence = sentences.Dequeue();
            dialogueText.text = sentence;
        }
    }

    //deactivates dialogue canvas
    public void EndDialogue()
    {
        dialogueCanvas.SetActive(false);
    }

}
