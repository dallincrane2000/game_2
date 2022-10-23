using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clueColisionClass
 : MonoBehaviour
{
    public DialogueTrigger dialogue;
    public journalMove journal;

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if(hitInfo.CompareTag("Player") && !gameObject.CompareTag("Bully"))
        {
            //coins ++;
            dialogue.TriggerDialogue();
            Destroy(gameObject);
        }
        if(hitInfo.CompareTag("Player") && gameObject.CompareTag("Bully"))
        {
            dialogue.TriggerDialogue();
        }
        if(hitInfo.CompareTag("Player") && gameObject.CompareTag("4") && journal.crowbar == true)
        {
            //dialogue.TriggerDialogue();
            SceneManager.LoadScene(2);
            //Switch scenes
        }
        else if(hitInfo.CompareTag("Player") && gameObject.CompareTag("4") && journal.crowbar == false)
        {
            dialogue.TriggerDialogue();
        }
    }
}
