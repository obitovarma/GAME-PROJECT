using UnityEngine;

public class PaperPlaneGlide : MonoBehaviour
{
    public float glideSpeed = 10f;
    public float glideAngle = 10f;
    public float maxGlideTime = 10f;

    private Rigidbody rb;
    private float elapsedGlideTime = 0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (elapsedGlideTime < maxGlideTime)
        {
            // Calculate glide direction
            Vector3 glideDirection = Quaternion.Euler(glideAngle, 0f, 0f) * Vector3.forward;

            // Move the paper plane
            transform.position += glideDirection * glideSpeed * Time.deltaTime;

            // Rotate the paper plane to match glide direction
            transform.rotation = Quaternion.LookRotation(glideDirection, Vector3.up);

            // Reduce the paper plane's velocity to simulate air resistance
            rb.velocity *= 0.99f;

            elapsedGlideTime += Time.fixedDeltaTime;
        }
        else
        {
            // Destroy the paper plane after maxGlideTime seconds
            //Destroy(gameObject);
        }
    }
}