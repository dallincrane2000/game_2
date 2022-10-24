using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollisionClass : MonoBehaviour
{

    public journalMove journalMove;
    private GameObject journal;

    void Start()
    {
        journal = GameObject.Find("JournalManager");
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.CompareTag("clueVents"))
        {
            journalMove.isVents = true;
            journal.GetComponent<journalManager>().isVents = journalMove.isVents;
        }
        if(collider.CompareTag("clueTree"))
        {
            journalMove.isTree = true;
        }
        if(collider.CompareTag("cluePlayground"))
        {
            journalMove.isPlayground = true;
            journal.GetComponent<journalManager>().isPlayground = journalMove.isPlayground;
        }
        if(collider.CompareTag("clueBully"))
        {
            journalMove.isBully = true;
        }
        if(collider.CompareTag("crowbar"))
        {
            journalMove.crowbar = true;
        }
        if(collider.CompareTag("1"))
        {
            journalMove.one = true;
        }
        if(collider.CompareTag("2"))
        {
            journalMove.two = true;
        }
        if(collider.CompareTag("3"))
        {
            journalMove.three = true;
        }
        if(collider.CompareTag("4"))
        {
            journalMove.four = true;
        }
        if(collider.CompareTag("5"))
        {
            journalMove.five = true;
        }
        if(collider.CompareTag("6"))
        {
            journalMove.six = true;
        }
        if(collider.CompareTag("7"))
        {
            journalMove.seven = true;
        }
        if(collider.CompareTag("8"))
        {
            journalMove.eight = true;
        }
        if(collider.CompareTag("9"))
        {
            journalMove.nine = true;
        }
    }

}   
