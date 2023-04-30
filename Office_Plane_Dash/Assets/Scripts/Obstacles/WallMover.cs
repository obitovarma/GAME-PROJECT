using UnityEngine;

public class WallMover : MonoBehaviour
{
    public GameObject wall1;
    public GameObject wall2;
    public float speed = 1.0f;
    public float distance = 5.0f;
    private Vector3 startPos1;
    private Vector3 startPos2;

    void Start()
    {
        // Record the starting positions of the walls
        startPos1 = wall1.transform.position;
        startPos2 = wall2.transform.position;
    }

    void Update()
    {
        // Move the walls back and forth using PingPong
        float x = Mathf.PingPong(Time.time * speed, distance);
        wall1.transform.position = startPos1 + Vector3.right * x;
        wall2.transform.position = startPos2 + Vector3.left * x;
    }
}
