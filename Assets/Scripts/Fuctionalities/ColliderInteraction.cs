using UnityEngine;

public class ColliderInteraction : MonoBehaviour
{
    // Enum to allow choosing the detection method in the Inspector
    public enum DetectionType { Collision, Trigger }
    public DetectionType detectionType = DetectionType.Collision;

    // Tag to filter which objects trigger the functionality
    public string targetTag = "Target";

    // Reference to the functionality to enable
    public MonoBehaviour functionalityToEnable;

    // Whether to enable or disable the functionality
    public bool enableFunctionality = true;

    // Called when a collision occurs
    private void OnCollisionEnter(Collision collision)
    {
        if (detectionType == DetectionType.Collision && collision.gameObject.CompareTag(targetTag))
        {
            HandleFunctionality();
        }
    }

    // Called when a trigger event occurs
    private void OnTriggerEnter(Collider other)
    {
        if (detectionType == DetectionType.Trigger && other.CompareTag(targetTag))
        {
            HandleFunctionality();
        }
    }

    // Function to handle enabling/disabling functionality
    private void HandleFunctionality()
    {
        if (functionalityToEnable != null)
        {
            functionalityToEnable.enabled = enableFunctionality;
        }
        else
        {
            Debug.LogWarning("Functionality to enable is not assigned.", this);
        }
    }
}
