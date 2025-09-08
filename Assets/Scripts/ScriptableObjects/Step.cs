using UnityEngine;

[CreateAssetMenu(fileName = "NewStep", menuName = "Learning/Step")]
public class Step : ScriptableObject
{
    [Header("Step Information")]
    public string stepName;    // Name of the step
    [TextArea]
    public string stepDetails; // Details about the step

    [Header("Step Status")]
    public bool isCompleted;   // Whether the step is completed
    public float estimatedDuration; // Optional: Estimate how long the step will take (in minutes)

    [Header("Step Type")]
    public StepType stepType; // Type of step (reading, quiz, practical, etc.)

    [Header("Prerequisite Steps")]
    public Step[] prerequisiteSteps; // Steps that need to be completed first

    // Method to update the completion status of the step
    public void MarkAsCompleted()
    {
        if (!isCompleted)
        {
            isCompleted = true;
            Debug.Log($"{stepName} has been marked as completed.");
        }
    }
}

// Enum to define various types of steps
public enum StepType
{
    Reading,
    Video,
    Quiz,
    Practical,
    Discussion,
    Review
}
