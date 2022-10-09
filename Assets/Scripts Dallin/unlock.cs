using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class unlock : MonoBehaviour
{
    //public Text codeText;
    [SerializeField] private TextMeshProUGUI codeText;
    string codeTextValue = "";
    public string PassCode;

    // Update is called once per frame
    void Update()
    {
        codeText.text = codeTextValue;

        if (codeTextValue == PassCode)
        {
            Debug.Log("Correct");
        }

        if (codeTextValue.Length >= 4)
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
