using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour
{
    public GameObject PauseMenu;

    void Update()
    {
        if (Input.GetKeyDown("escape") && (PauseMenu.activeSelf == true))
        {
            PauseMenu.SetActive(false);
            Time.timeScale = 1f;
        } else if (Input.GetKeyDown("escape") && (PauseMenu.activeSelf == false))
        {
            PauseMenu.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ResumeGame()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
}
