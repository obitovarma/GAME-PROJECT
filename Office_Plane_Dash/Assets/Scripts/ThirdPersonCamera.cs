using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Transform target; // Drag the player object onto this variable in the Inspector
    public float distance = 5.0f; // Distance of the camera from the player
    public float height = 2.0f; // Height of the camera above the player
    public float rotationDamping = 3.0f; // Damping factor for camera rotation
    public float heightDamping = 2.0f; // Damping factor for camera height

    void LateUpdate()
    {
        // Calculate the desired camera position and rotation
        float desiredAngle = target.eulerAngles.y;
        float desiredHeight = target.position.y + height;
        float currentAngle = transform.eulerAngles.y;
        float currentHeight = transform.position.y;

        currentAngle = Mathf.LerpAngle(currentAngle, desiredAngle, rotationDamping * Time.deltaTime);
        currentHeight = Mathf.Lerp(currentHeight, desiredHeight, heightDamping * Time.deltaTime);

        Quaternion currentRotation = Quaternion.Euler(0, currentAngle, 0);

        Vector3 targetPosition = target.position - currentRotation * Vector3.forward * distance;
        targetPosition.y = currentHeight;

        // Set the camera position and rotation
        transform.position = targetPosition;
        transform.LookAt(target);
    }
}