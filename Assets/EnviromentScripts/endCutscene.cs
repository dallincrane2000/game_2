using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endCutscene : MonoBehaviour
{
    private Animator animationScene;
    private Animator animationBully;
    public static bool isCutSceneOn;
    public DialogueTrigger dialogue;
    public DialogueTrigger dialogue2;
    public int count = 0;
    public GameObject player;

    void Start()
    {
        animationScene = GameObject.Find("cameraControl").GetComponent<Animator>();
        animationBully = GameObject.Find("clueBully").GetComponent<Animator>();
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            isCutSceneOn = true;
            count += 1;
            player.GetComponent<PlayerMovement>().speed = 0f;
            player.GetComponent<PlayerMovement>().jumpVelocity = 0f;
            animationScene.SetBool("cutscene1", true);
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
        Destroy(gameObject);
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
