using UnityEngine;

public class TouchController : MonoBehaviour
{
    private Vector2 fingerDownPosition;
    private Vector2 fingerUpPosition;

    public float swipeThreshold = 50f;
    public float moveSpeed = 5f;

    void Update()
    {
        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            fingerDownPosition = Input.GetTouch(0).position;
            fingerUpPosition = Input.GetTouch(0).position;
        }

        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            fingerUpPosition = Input.GetTouch(0).position;
        }

        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            if (Mathf.Abs(fingerDownPosition.y - fingerUpPosition.y) < swipeThreshold)
            {
                if (fingerDownPosition.x - fingerUpPosition.x > swipeThreshold) // Swipe left
                {
                    transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
                }
                else if (fingerUpPosition.x - fingerDownPosition.x > swipeThreshold) // Swipe right
                {
                    transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
                }
            }
        }
    }
}