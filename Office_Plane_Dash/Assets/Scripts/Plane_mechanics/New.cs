using UnityEngine;

public class PaperPlane : MonoBehaviour
{
    private bool isFlying = false;
    private Vector2 touchStartPosition;
    public float flightSpeed = 5f; // flight speed of the paper plane
    public float rotationSpeed = 5f; // rotation speed of the paper plane

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // Check for touch phase
            if (touch.phase == TouchPhase.Began)
            {
                // Store the touch start position
                touchStartPosition = touch.position;
                isFlying = true;
            }
            else if (touch.phase == TouchPhase.Moved && isFlying)
            {
                // Calculate the rotation direction based on the touch movement
                float rotationDirection = Mathf.Sign(touch.deltaPosition.x);

                // Calculate the target rotation angle
                float targetRotation = rotationDirection * rotationSpeed * Time.deltaTime;

                // Rotate the paper plane around the X-axis
                transform.Rotate(targetRotation, 0f, 0f, Space.Self);

                // Move the paper plane forward
                transform.position += transform.forward * flightSpeed * Time.deltaTime;
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                isFlying = false;
            }
        }
    }
}
