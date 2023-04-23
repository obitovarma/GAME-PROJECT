using UnityEngine;

public class Boost_up : MonoBehaviour
{
    public float normalSpeed = 5f;          // Normal speed of the paper plane
    public float boostedSpeed = 15f;        // Boosted speed of the paper plane
    public float boostDuration = 3f;        // Duration of the boost in seconds
    public float boostHeight = 10f;         // Height of the boost in units

    private bool isBoosting = false;        // Flag to track if the paper plane is currently boosting
    private float boostTimer = 0f;          // Timer to track the duration of the boost

    void OnTriggerEnter(UnityEngine.Collider other)
    {
        if (other.gameObject.tag == "BoostUp" && !isBoosting)
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
        transform.position += transform.forward * currentSpeed * Time.deltaTime;
    }

    private void StartBoost()
    {
        // Start the boost by setting the isBoosting flag to true and resetting the boost timer
        isBoosting = true;
        boostTimer = 0f;

        // Move the paper plane upwards by the specified height during the boost
        transform.position += -transform.right * boostHeight;
    }

    private void StopBoost()
    {
        // Stop the boost by setting the isBoosting flag to false
        isBoosting = false;
    }
}
