using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
public class Trial_Text : MonoBehaviour
{
    public TextMeshProUGUI TextField;


        public void ChangeText(string newText)
        {
            TextField.text = newText;
        }
}