using UnityEngine;

public class update : MonoBehaviour
{
    private Touch touch;
    public float speedModifier = 0.01f;
    public float rotationSpeed = 5f;
    public float turnSpeed = 10f;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                // Invert the x direction of the touch input to move the object in the opposite direction
                transform.position = new Vector3(
                    transform.position.x - touch.deltaPosition.x * speedModifier,
                    transform.position.y,
                    transform.position.z);

                // Calculate the target rotation angles around X and Y axes based on touch delta position
                float targetRotationX = touch.deltaPosition.y * rotationSpeed * Time.deltaTime * turnSpeed;
                float targetRotationY = touch.deltaPosition.x * rotationSpeed * Time.deltaTime; 


                // Rotate the paper plane around the X and Y axes locally
                transform.Rotate(targetRotationX, targetRotationY, 0f, Space.Self);
            }
        }
    }
}
