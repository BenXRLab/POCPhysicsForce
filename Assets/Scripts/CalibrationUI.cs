using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class CalibrationUI : MonoBehaviour
{
    public TextMeshProGUI TextField;

    public void ChangeText(string newText)
    {
        TextField.text = newText;
    }
}
