using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class unlock : MonoBehaviour
{
    //public Text codeText;
    [SerializeField] private TextMeshProUGUI codeText;
    public string codeTextValue = "";
    public string PassCode;

    // Update is called once per frame
    void Update()
    {
        codeText.text = codeTextValue;

        if (codeTextValue == PassCode)
        {
            Debug.Log("Correct");
            gameObject.SetActive(false);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        else if (codeTextValue.Length >= 4)
        {
            codeTextValue = "";
            Debug.Log("Incorrect");
        }
    }

    public void AddDigit(string digit)
    {
        codeTextValue += digit;
    }
}
