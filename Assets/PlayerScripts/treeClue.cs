using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeClue : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if(hitInfo.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
