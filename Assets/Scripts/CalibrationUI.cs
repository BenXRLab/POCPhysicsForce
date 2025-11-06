using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class CalibrationUI : MonoBehaviour
{
    private const string not_calibrated = "Please place trolley and weight on the track.";
    private const string calibrated = "Calibration Complete.";
    // calibration is a test variable, remove when CalibrationCheck.cs is made
    private bool calibration = true;
    public TextMeshProUGUI TextField;
    private string newText;


    // Triggers a delay if button is pressed


    // changes text on the panel
    // updates the result every frame
    // Starts an update delay timer if the start trial button is pressed


    void Update()
    { 
            if (calibration == true)
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
    
