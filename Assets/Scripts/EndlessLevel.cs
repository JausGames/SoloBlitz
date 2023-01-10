using System.Collections.Generic;
using UnityEngine;

public class EndlessLevel : MonoBehaviour
{
    public GameObject levelSegmentPrefab;
    public Transform levelContainer;
    public int numberOfSegments = 10;
    public float segmentSize = 50f;
    public float levelSpeed = 10f;

    private Queue<GameObject> levelSegmentQueue = new Queue<GameObject>();
    private Vector3 lastSegmentPosition;

    void Start()
    {
        lastSegmentPosition = levelContainer.position;
        for (int i = 0; i < numberOfSegments; i++)
        {
            AddSegment();
        }
    }

    void Update()
    {
        levelContainer.position += Vector3.back * levelSpeed * Time.deltaTime;

        if (levelContainer.position.z >= segmentSize)
        {
            levelContainer.position -= Vector3.back * segmentSize;
            RemoveSegment();
            AddSegment();
        }
    }

    void AddSegment()
    {
        GameObject segment = Instantiate(levelSegmentPrefab, lastSegmentPosition, Quaternion.identity);
        segment.transform.parent = levelContainer;
        lastSegmentPosition = segment.transform.GetChild(0).position;
        levelSegmentQueue.Enqueue(segment);
    }

    void RemoveSegment()
    {
        GameObject segment = levelSegmentQueue.Dequeue();
        Destroy(segment);
    }
}
