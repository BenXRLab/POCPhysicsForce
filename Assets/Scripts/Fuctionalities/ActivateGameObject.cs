using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateGameObject : MonoBehaviour
{
    [SerializeField]
    private GameObject gameObjectToACtivate;
    [SerializeField]
    private float delayTime;

    public void Start()
    {
        ActivateAfterDelay();
    }
    public void ActivateAfterDelay()
    {
        if (gameObjectToACtivate != null)
        {
            StartCoroutine(DelayedActivationRoutine());
        }
        else
        {
            Debug.LogWarning("Target GameObject is not assigned.", this);
        }
    }

    // Coroutine to handle the delay
    private IEnumerator DelayedActivationRoutine()
    {
        yield return new WaitForSeconds(delayTime); // Wait for the specified time
        gameObjectToACtivate.SetActive(true);       // Activate the GameObject
    }
}
