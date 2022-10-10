using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clueColision : MonoBehaviour
{
    public DialogueTrigger dialogue;
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if(hitInfo.CompareTag("Player"))
        {
            //coins ++;
            dialogue.TriggerDialogue();
            Destroy(gameObject);
        }
    }

    void OnTriggerExit2D(Collider2D hitInfo)
    {

    }
}
