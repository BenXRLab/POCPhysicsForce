using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class TopicManager : MonoBehaviour
{
    [Header("UI References")]
    public Button topicButtonPrefab;     // Prefab for the topic button
    public Transform topicButtonsParent; // Parent object to spawn topic buttons

    public LearningManager learningManager; // Reference to LearningManager

    public void DisplayTopics(Subject subject)
    {
        ClearTopicButtons();

        foreach (var topic in subject.topics)
        {
            var button = Instantiate(topicButtonPrefab, topicButtonsParent);
            button.GetComponentInChildren<TextMeshProUGUI>().text = topic.topicName;
            button.onClick.AddListener(() => OnTopicSelected(topic));
        }
    }

    void OnTopicSelected(Topic topic)
    {
        learningManager.DisplaySteps(topic);
    }

    void ClearTopicButtons()
    {
        foreach (Transform child in topicButtonsParent)
        {
            Destroy(child.gameObject);
        }
    }
}

