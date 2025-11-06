using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using System;
public class Trial_Text : MonoBehaviour
{
    public TextMeshProUGUI TextField;


    //Sets Text to Trial not Running
    private void OldText()
    {
        string oldText = "Trial not Running";
        TextField.text = oldText;
    }
    // Sets text to Trial Running
    public void NewText()
    {
        string oldText = "Trial Running...";
        TextField.text = oldText;
    }

}
