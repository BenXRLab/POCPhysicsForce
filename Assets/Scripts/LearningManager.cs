using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LearningManager : MonoBehaviour
{
    [Header("UI References")]
    public Transform topicsParent;       // Parent object for spawning topic UI buttons
    public GameObject topicUIPrefab;     // Prefab for topic UI buttons
    public Transform stepsParent;        // Parent object for spawning step UI buttons
    public GameObject stepUIPrefab;      // Prefab for step UI buttons
    public GameObject stepDetailsPanel;  // Panel to show step details
    public TextMeshProUGUI stepDetailsText; // Text field for step details
    public Button closeButton;           // Button to close the details panel

    [Header("Navigation")]
    public GameObject subjectsPanel;     // Panel containing subject selection
    public GameObject topicsPanel;       // Panel containing topic selection
    public GameObject stepsPanel;        // Panel containing steps

    private List<GameObject> spawnedTopics = new List<GameObject>();
    private List<GameObject> spawnedSteps = new List<GameObject>();
    private Topic currentTopic;

    void Start()
    {
        stepDetailsPanel.SetActive(false);
        closeButton.onClick.AddListener(CloseStepDetails);
    }

    // Display topics when a subject is selected
    public void DisplayTopics(Subject subject)
    {
        if (subject == null || subject.topics == null || subject.topics.Count == 0)
        {
            Debug.LogWarning("No topics available for the selected subject.");
            return;
        }

        ClearTopics();
        subjectsPanel.SetActive(false);
        topicsPanel.SetActive(true);

        foreach (var topic in subject.topics)
        {
            CreateTopicButton(topic);
        }
    }

    // Create UI buttons for each topic
    private void CreateTopicButton(Topic topic)
    {
        GameObject topicUI = Instantiate(topicUIPrefab, topicsParent);
        spawnedTopics.Add(topicUI);

        TextMeshProUGUI topicNameText = topicUI.GetComponentInChildren<TextMeshProUGUI>();
        Button topicButton = topicUI.GetComponent<Button>();

        if (topicNameText != null) topicNameText.text = topic.topicName;

        topicButton.onClick.AddListener(() => DisplaySteps(topic));
    }

    // Display steps when a topic is selected
    public void DisplaySteps(Topic topic)
    {
        if (topic == null || topic.steps == null || topic.steps.Count == 0)
        {
            Debug.LogWarning("No steps available for the selected topic.");
            return;
        }

        ClearSteps();
        topicsPanel.SetActive(false);
        stepsPanel.SetActive(true);

        currentTopic = topic;

        foreach (var step in topic.steps)
        {
            CreateStepButton(step);
        }
    }

    // Create UI buttons for each step
    private void CreateStepButton(Step step)
    {
        GameObject stepUI = Instantiate(stepUIPrefab, stepsParent);
        spawnedSteps.Add(stepUI);

        TextMeshProUGUI stepNameText = stepUI.GetComponentInChildren<TextMeshProUGUI>();
        Button stepButton = stepUI.GetComponent<Button>();
        Image tickIcon = stepUI.transform.Find("TickIcon")?.GetComponent<Image>();

        if (stepNameText != null) stepNameText.text = step.stepName;
        if (tickIcon != null) tickIcon.gameObject.SetActive(step.isCompleted);

        stepButton.onClick.AddListener(() => OnStepSelected(step, stepUI));
    }

    // When a step is selected, show details and mark it as completed
    private void OnStepSelected(Step step, GameObject stepUI)
    {
        if (step == null) return;

        stepDetailsPanel.SetActive(true);
        stepDetailsText.text = step.stepDetails;
        step.isCompleted = true;

        Image tickIcon = stepUI.transform.Find("TickIcon")?.GetComponent<Image>();
        if (tickIcon != null) tickIcon.gameObject.SetActive(true);
    }

    // Close the step details panel
    private void CloseStepDetails()
    {
        stepDetailsPanel.SetActive(false);
    }

    // Clear previous topics when selecting a new subject
    private void ClearTopics()
    {
        foreach (var topicUI in spawnedTopics)
        {
            Destroy(topicUI);
        }
        spawnedTopics.Clear();
    }

    // Clear previous steps when selecting a new topic
    private void ClearSteps()
    {
        foreach (var stepUI in spawnedSteps)
        {
            Destroy(stepUI);
        }
        spawnedSteps.Clear();
    }
}
