using UnityEngine;

public class PaperPlaneShield : MonoBehaviour
{
    // The number of collisions the shield can withstand
    public int maxCollisions = 2;

    // The current number of collisions the shield has withstood
    private int currentCollisions = 0;

    // The audio clip to play when the shield is hit
    public AudioClip hitSound;

    // Reference to the audio source component
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        // Get the audio source component
        audioSource = GetComponent<AudioSource>();
    }

    // Called when the shield is hit by a collider
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with a bullet
        if (collision.gameObject.tag == "Bullet")
        {
            // Play the hit sound effect
            audioSource.PlayOneShot(hitSound);

            // Increment the number of collisions the shield has withstood
            currentCollisions++;

            // Check if the shield has reached its maximum collisions
            if (currentCollisions >= maxCollisions)
            {
                // If so, destroy the shield object
                Destroy(gameObject);
            }
        }
    }
}
