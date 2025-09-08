using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "NewTopic", menuName = "Learning/Topic")]
public class Topic : ScriptableObject
{
    [Header("Basic Information")]
    public string topicName; // Name of the topic
    public string topicDescription; // Description of the topic, useful for showing more context

    [Header("Topic Steps")]
    public List<Step> steps; // List of steps for this topic

    [Header("Additional Resources")]
    public Sprite topicImage; // Optional image or icon to visually represent the topic
    public bool isCompleted; // Indicates if the topic is completed, useful for tracking progress

    // You could add additional methods or properties to manage this topic in a scalable way in the future.
}
