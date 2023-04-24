using UnityEngine;

public class PaperPlaneController : MonoBehaviour
{
    public float speed = 10f; // Speed of the paper plane
    private float totalDistance; // Total distance traveled
    private Vector3 lastPosition; // Last position of the paper plane

    void Start()
    {
        lastPosition = transform.position; // Set initial position of the paper plane
    }

    void Update()
    {
        // Move the paper plane forward based on its speed
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Calculate distance between current position and last position
        float distanceDelta = Vector3.Distance(transform.position, lastPosition);
        totalDistance += distanceDelta; // Add to total distance
        lastPosition = transform.position; // Update last position for next frame

        // Update UI or game logic with the total distance traveled
        // For example, you could display it on-screen or use it for scoring

        Debug.Log("Total Distance Traveled: " + totalDistance);
    }
}