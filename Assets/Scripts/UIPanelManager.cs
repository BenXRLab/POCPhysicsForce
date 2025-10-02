using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPanelManager : MonoBehaviour
{
    public GameObject canvas;
    // Start is called before the first frame update
   /* public void ShowCanvas()
    {
         //Activates the GameObject
        canvas.SetActive(true);
    }*/

    // Update is called once per frame
    public void HideCanvas()
    {
        // Deativates the GameObject
        canvas.SetActive(false);
    }
}
