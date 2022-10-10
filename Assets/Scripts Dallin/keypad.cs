using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keypad : MonoBehaviour
{
    // keyPad object to enable and disable 
    public GameObject keyPad;

    
    // Runs when player enters the keypad area
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Outside");
        if (collision.gameObject.CompareTag("Player"))
        {
            // Enables the Keypad overlay
            Debug.Log("here");
            keyPad.SetActive(true);
        }
    }
    // Runs when player leaves the Keypad Area
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // disables the Keypad overlay
            keyPad.SetActive(false);
        }
    }
}
