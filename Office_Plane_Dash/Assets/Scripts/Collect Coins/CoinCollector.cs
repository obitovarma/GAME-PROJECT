using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    public int coinValue = 10; // The amount of score added when the coin is collected
    public AudioClip coinSound; // The sound effect to play when the coin is collected
    public AudioSource audioSource; // The audio source to play the sound effect

    void OnTriggerEnter(UnityEngine.Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Play the coin sound effect
            if (coinSound != null && audioSource != null)
            {
                audioSource.PlayOneShot(coinSound);
            }

            // Destroy the coin GameObject
            Destroy(gameObject);
        }
    }
}
