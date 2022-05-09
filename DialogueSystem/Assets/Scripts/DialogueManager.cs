using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public GameObject dialogueCanvas;
    public Text nameText;
    public Text dialogueText;
    private Queue<string> sentences;
    private Button[] buttons;

    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue d)
    {
        dialogueCanvas.SetActive(true);
        nameText.text = d.name;

        sentences.Clear();

        foreach(string s in d.sentences){
            sentences.Enqueue(s);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if(sentences.Count == 0){
            EndDialogue();
            return;
        }

        else{
            string sentence = sentences.Dequeue();
            dialogueText.text = sentence;
        }
    }

    public void EndDialogue()
    {
        dialogueCanvas.SetActive(false);
    }

}
