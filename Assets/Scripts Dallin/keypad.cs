using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keypad : MonoBehaviour
{
    // keyPad object to enable and disable 
    public GameObject keyPad;
    // Passcode (Work in Progress)
    public string code;

    // Runs when player enters the keypad area
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Enables the Keypad overlay
            keyPad.SetActive(true);
        }
    }
    // Runs when player leaves the Keypad Area
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // disables the Keypad overlay
            keyPad.SetActive(false);
        }
    }
}
