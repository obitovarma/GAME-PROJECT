using UnityEngine;

public class Boost_up : MonoBehaviour
{
    public float normalSpeed = 5f;          // Normal speed of the paper plane
    public float boostedSpeed = 15f;        // Boosted speed of the paper plane
    public float boostDuration = 3f;        // Duration of the boost in seconds
    public float boostForce = 10f;          // Force applied to the paper plane during boost

    private Rigidbody rb;                  // Reference to the Rigidbody component of the paper plane
    private bool isBoosting = false;        // Flag to track if the paper plane is currently boosting
    private float boostTimer = 0f;          // Timer to track the duration of the boost

    private void Start()
    {
        // Get the reference to the Rigidbody component
        rb = GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(UnityEngine.Collider other) {
        
        
            if (other.gameObject.tag == "BoostUp"&& !isBoosting)
            {
                // Trigger the boost when the Space key is pressed and the paper plane is not already boosting
                StartBoost();
            }

            if (isBoosting)
            {
                // Update the boost timer while the paper plane is boosting
                boostTimer += Time.deltaTime;

                if (boostTimer >= boostDuration)
                {
                    // Stop the boost when the boost duration is over
                    StopBoost();
                }
            }

            // Move the paper plane forward with the appropriate speed
            float currentSpeed = isBoosting ? boostedSpeed : normalSpeed;
            rb.velocity = transform.forward * currentSpeed;
        }

        private void StartBoost()
        {
            // Start the boost by setting the isBoosting flag to true and applying an upward force to the paper plane
            isBoosting = true;
            rb.AddForce(Vector3.up * boostForce, ForceMode.Impulse);
        }

        private void StopBoost()
        {
            // Stop the boost by setting the isBoosting flag to false
            isBoosting = false;
        }
    
}
