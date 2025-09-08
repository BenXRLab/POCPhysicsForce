using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SubjectManager : MonoBehaviour
{
    [Header("UI References")]
    public Button subjectButtonPrefab;      // Prefab for the subject button
    public Transform subjectButtonsParent;  // Parent object to spawn subject buttons

    public List<Subject> subjects; // List of all available subjects
    public TopicManager topicManager; // Reference to TopicManager

    void Start()
    {
        GenerateSubjectButtons();
    }

    void GenerateSubjectButtons()
    {
        foreach (var subject in subjects)
        {
            var button = Instantiate(subjectButtonPrefab, subjectButtonsParent);
            button.GetComponentInChildren<TextMeshProUGUI>().text = subject.subjectName;
            button.onClick.AddListener(() => OnSubjectSelected(subject));
        }
    }

    void OnSubjectSelected(Subject subject)
    {
        topicManager.DisplayTopics(subject);
    }
}

