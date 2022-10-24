using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clueColisionClass: MonoBehaviour
{
    public DialogueTrigger dialogue;
    public GameObject bullyPrefab;
    public GameObject endCutscene;
    public Transform cutsceneTrigger;
    public Transform bullySpawn;
    public journalMove journal;

    IEnumerator OnTriggerEnter2D(Collider2D hitInfo)
    {
        if(hitInfo.CompareTag("Player") && !gameObject.CompareTag("Bully"))
        {
            //coins ++;
            dialogue.TriggerDialogue();
            if(hitInfo.CompareTag("Player") && gameObject.CompareTag("1"))
            {
                yield return new WaitForSeconds(5);
                Instantiate(bullyPrefab, bullySpawn.position, bullySpawn.rotation);
                Instantiate(endCutscene, cutsceneTrigger.position, cutsceneTrigger.rotation);
            }
            Destroy(gameObject);
        }
        if(hitInfo.CompareTag("Player") && gameObject.CompareTag("Bully"))
        {
            dialogue.TriggerDialogue();
        }
        if(hitInfo.CompareTag("Player") && gameObject.CompareTag("4") && journal.crowbar == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else if(hitInfo.CompareTag("Player") && gameObject.CompareTag("4") && journal.crowbar == false)
        {
            dialogue.TriggerDialogue();
        }
    }
}
