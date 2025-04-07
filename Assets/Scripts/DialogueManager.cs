using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;

    public string[] dialogueLines;
    private int index = 0;

    void Start()
    {
        if (dialogueLines.Length > 0)
        {
            dialogueText.text = dialogueLines[index];
        }
    }

    public void NextDialogue()
    {
        
        index++;

        if (index >= dialogueLines.Length)
        {
            index = 0; // Loop back to the start
        }

        dialogueText.text = dialogueLines[index];
    }
}
