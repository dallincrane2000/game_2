using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endCutscene : MonoBehaviour
{
    private Animator animationScene;
    public static bool isCutSceneOn;
    public DialogueTrigger dialogue;
    private DialogueTrigger dialogue2;
    private journalMove journal;
    public int count = 0;
    private GameObject player;
    private GameObject bully;

    void Start()
    {
        animationScene = GameObject.Find("cameraControl").GetComponent<Animator>();
        dialogue2 = GameObject.Find("Dialogue").GetComponent<DialogueTrigger>();
        journal = GameObject.Find("JournalManager1").GetComponent<journalMove>();
        bully = GameObject.Find("clueBully(Clone)");
        player = GameObject.Find("Player");
    }


    IEnumerator OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            isCutSceneOn = true;
            journal.isBully = true;
            count += 1;
            player.GetComponent<PlayerMovement>().speed = 0f;
            player.GetComponent<PlayerMovement>().jumpVelocity = 0f;
            animationScene.SetBool("cutscene1", true);
            dialogueSet();
            yield return new WaitForSeconds(4);
            
            Invoke(nameof(StopCutscene), 5f);
        }
    }

    void StopCutscene()
    {
        isCutSceneOn = false;
        
        player.GetComponent<PlayerMovement>().speed = 7f;
        player.GetComponent<PlayerMovement>().jumpVelocity = 12f;
        animationScene.SetBool("cutscene1", false);
        Destroy(gameObject);
        Destroy(bully);
    }


    void dialogueSet()
    {
        if(count == 1)
        {
            dialogue.TriggerDialogue();
            count += 1;
        }
        else if(count > 1)
        {
            dialogue2.TriggerDialogue();
        }
    }
}
