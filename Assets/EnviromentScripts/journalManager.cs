using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class journalManager : MonoBehaviour
{
    private GameObject journalCanvas;
    private Transform itemSlot;
    private Transform ClueLog;
    private bool isOpen = false;

    public bool isVents = false;
    public bool isPlayground = false;
    public bool isTree = false;
    public bool isBully = false;
    public bool crowbar = false;

    public bool one = false;
    public bool two = false;
    public bool three = false;
    public bool four = false;
    public bool five = false;
    public bool six = false;
    public bool seven = false;
    public bool eight = false;
    public bool nine = false;
    string sceneName = "StartingScene";
    
    void Start()
    {
        journalCanvas = GameObject.Find("JournalCanvas");
        itemSlot = GameObject.Find("itemSlotContainer").transform;
        ClueLog = GameObject.Find("clueLogContainer").transform;
        journalCanvas.SetActive(false);
        itemSlot.GetChild(0).gameObject.SetActive(false);
        itemSlot.GetChild(1).gameObject.SetActive(false);
        itemSlot.GetChild(2).gameObject.SetActive(false);
        itemSlot.GetChild(3).gameObject.SetActive(false);
        itemSlot.GetChild(4).gameObject.SetActive(false);

        ClueLog.GetChild(0).gameObject.SetActive(false);
        ClueLog.GetChild(1).gameObject.SetActive(false);
        ClueLog.GetChild(2).gameObject.SetActive(false);
        ClueLog.GetChild(3).gameObject.SetActive(false);
        ClueLog.GetChild(4).gameObject.SetActive(false);
        ClueLog.GetChild(5).gameObject.SetActive(false);
        ClueLog.GetChild(6).gameObject.SetActive(false);
        ClueLog.GetChild(7).gameObject.SetActive(false);
        ClueLog.GetChild(8).gameObject.SetActive(false);
    }


    void Update()
    {
            if(Input.GetKeyDown(KeyCode.Tab) && SceneManager.GetActiveScene() == SceneManager.GetSceneByName(sceneName))
            {
                if(isVents == true)
                {
                    Debug.Log("vents is true");
                    itemSlot.GetChild(0).gameObject.SetActive(true);
                }
                if(isPlayground == true)
                {
                    itemSlot.GetChild(1).gameObject.SetActive(true);
                }
                if(isBully == true)
                {
                    itemSlot.GetChild(2).gameObject.SetActive(true);
                }
                if(isTree == true)
                {
                    itemSlot.GetChild(3).gameObject.SetActive(true);
                }
                if(crowbar == true)
                {
                    itemSlot.GetChild(4).gameObject.SetActive(true);
                }
                if(one == true)
                {
                    ClueLog.GetChild(0).gameObject.SetActive(true);
                }
                if(two == true)
                {
                    ClueLog.GetChild(1).gameObject.SetActive(true);
                }
                if(three == true)
                {
                    ClueLog.GetChild(2).gameObject.SetActive(true);
                }
                if(four == true)
                {
                    ClueLog.GetChild(3).gameObject.SetActive(true);
                }
                if(five == true)
                {
                    ClueLog.GetChild(4).gameObject.SetActive(true);
                }
                if(six == true)
                {
                    ClueLog.GetChild(5).gameObject.SetActive(true);
                }
                if(seven == true)
                {
                    ClueLog.GetChild(6).gameObject.SetActive(true);
                }
                if(eight == true)
                {
                    ClueLog.GetChild(7).gameObject.SetActive(true);
                }
                if(nine == true)
                {
                    ClueLog.GetChild(8).gameObject.SetActive(true);
                }
                isOpen = !isOpen;
                journalCanvas.SetActive(isOpen);
            }
    }
}

