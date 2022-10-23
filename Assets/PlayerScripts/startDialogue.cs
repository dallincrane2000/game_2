using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startDialogue : MonoBehaviour
{
    public DialogueTrigger dialogue;

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if(hitInfo.CompareTag("Player"))
        {
            dialogue.TriggerDialogue();
            Destroy(gameObject);
        }
    }
}

