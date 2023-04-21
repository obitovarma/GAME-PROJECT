using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Drag the player object onto this variable in the Inspector
    public Vector3 offset = new Vector3(0, 2, -5); // Customize the camera offset here

    void LateUpdate()
    {
        transform.position = player.position + offset;

        // Set the camera's rotation to match the player's rotation
        transform.rotation = player.rotation;

        // Rotate the camera by 90 degrees on the Y-axis
        transform.Rotate(Vector3.up, 90f * Time.deltaTime);

        transform.LookAt(player.position);
    }
}