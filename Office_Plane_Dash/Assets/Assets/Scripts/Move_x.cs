using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_x: MonoBehaviour
{
    private Touch touch;
    public float speedModifier = 0.01f;
    public float rotationSpeed = 5f; // new variable to control rotation speed

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                // Invert the x direction of the touch input to move the object in the opposite direction
                transform.position = new Vector3(
                    transform.position.x,
                    transform.position.y,
                    transform.position.z +touch.deltaPosition.y * speedModifier); // Update to use deltaPosition.y for position on Z-axis

                float rotationY = touch.deltaPosition.x * rotationSpeed;
                transform.Rotate(0f, rotationY, 0f, Space.Self);
            }
        }
    }

}
    


