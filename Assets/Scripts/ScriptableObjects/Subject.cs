using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "NewSubject", menuName = "Learning/Subject")]
public class Subject : ScriptableObject
{
    [Header("Basic Information")]
    public string subjectName; // Name of the subject (e.g., Physics, Chemistry)
    public string subjectDescription; // Description of the subject

    [Header("Related Topics")]
    public List<Topic> topics; // List of topics under this subject

    // You could add more features to handle subject-specific logic
}
