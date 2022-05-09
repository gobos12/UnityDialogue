using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue; //adding your own dialogue in-game

    //triggers dialogue when you interact with gameobject
    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

}
