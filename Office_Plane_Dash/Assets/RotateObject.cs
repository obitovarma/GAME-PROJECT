using UnityEngine;

public class RotateObject : MonoBehaviour
{
    // Update is called once per frame
  

    public void RotateBy90Degrees()
    {
        // Get the current rotation of the game object
        Vector3 currentRotation = transform.eulerAngles;

        // Add 90 degrees to the current rotation on the Y-axis
        Vector3 newRotation = new Vector3(currentRotation.x, currentRotation.y + 90f, currentRotation.z);

        // Set the new rotation to the game object
        transform.eulerAngles = newRotation;
    }
}