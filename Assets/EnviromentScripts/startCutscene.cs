using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startCutscene : MonoBehaviour
{
    public Animator animationScene;
    public Animator animationBully;
    public static bool isCutSceneOn;
    public DialogueTrigger dialogue;
    public DialogueTrigger dialogue2;
    public int count = 0;
    public GameObject player;

    void Start()
    {
        animationScene = GameObject.Find("cameraControl").GetComponent<Animator>();
        animationBully = GameObject.Find("clueBully").GetComponent<Animator>();
        dialogue2 = GameObject.Find("Dialogue").GetComponent<DialogueTrigger>();
        player = GameObject.Find("Player");
    }


    IEnumerator OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            isCutSceneOn = true;
            player.GetComponent<PlayerMovement>().speed = 0f;
            player.GetComponent<PlayerMovement>().jumpVelocity = 0f;
            animationScene.SetBool("cutscene1", true);
            count += 1;
            dialogueSet();
            yield return new WaitForSeconds(4);
            setAnimation();
            yield return new WaitForSeconds(4);
            dialogueSet();
            Invoke(nameof(StopCutscene), 5f);
        }
    }

    void StopCutscene()
    {
        isCutSceneOn = false;
        player.GetComponent<PlayerMovement>().speed = 7f;
        player.GetComponent<PlayerMovement>().jumpVelocity = 12f;
        animationScene.SetBool("cutscene1", false);
        animationBully.SetBool("ripping", false);
        Destroy(gameObject);
    }
    void setAnimation()
    {
        animationBully.SetBool("ripping", true);
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
