using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollisionClass : MonoBehaviour
{

    public journalMove journal;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.CompareTag("clueVents"))
        {
            journal.isVents = true;
        }
        if(collider.CompareTag("clueTree"))
        {
            journal.isTree = true;
        }
        if(collider.CompareTag("cluePlayground"))
        {
            journal.isPlayground = true;
        }
        if(collider.CompareTag("clueBully"))
        {
            journal.isBully = true;
        }
        if(collider.CompareTag("crowbar"))
        {
            journal.crowbar = true;
        }
        if(collider.CompareTag("1"))
        {
            journal.one = true;
        }
        if(collider.CompareTag("2"))
        {
            journal.two = true;
        }
        if(collider.CompareTag("3"))
        {
            journal.three = true;
        }
        if(collider.CompareTag("4"))
        {
            journal.four = true;
        }
        if(collider.CompareTag("5"))
        {
            journal.five = true;
        }
        if(collider.CompareTag("6"))
        {
            journal.six = true;
        }
        if(collider.CompareTag("7"))
        {
            journal.seven = true;
        }
        if(collider.CompareTag("8"))
        {
            journal.eight = true;
        }
        if(collider.CompareTag("9"))
        {
            journal.nine = true;
        }
    }

}   
