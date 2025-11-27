using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using System;

public class CalibrationUI : MonoBehaviour
{
    // Text outputs
    private const string not_calibrated = "Please place trolley and weight on the track.";
    private const string calibrated = "Calibration Complete.";
    private const string Trial_Text = "Trial Running...";
    // calibration is a test variable, remove when CalibrationCheck.cs is made
    private bool calibration = true;
    private bool Trial_Active = false;
    public TextMeshProUGUI TextField;
    private string newText;





    //Used by Start Trial button to change trial status
    public void Trial_Activate()
    {
        Trial_Active = true;
    }
    //Currently unused function to set trial status to inactive
    public void Trial_Deactivate()
    {
        Trial_Active = false;
    }


    // changes text on the panel using 3 options
    // updates the result every frame
    void Update()
    { 
            if (calibration == true)
            {
                if (Trial_Active)
                {
                newText = Trial_Text;
                TextField.text = newText;
                }
                else
                {
                newText = calibrated;
                TextField.text = newText;
                }

            }
            else
            {
                newText = not_calibrated;
                TextField.text = newText;
            }
    }
}

    
