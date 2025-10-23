using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class CalibrationUI : MonoBehaviour
{
    private const string not_calibrated = "Please place trolley and weight on the track.";
    private const string calibrated = "Calibration Complete.";
    private bool calibration = true;
    public TextMeshProUGUI TextField;


    public void ChangeText(string newText)
    {
        if (calibration==true)
        {
            newText = calibrated;
            TextField.text = newText;
        }
        else
        {
            newText = not_calibrated;
            TextField.text = newText;
        }
    }
    
}
