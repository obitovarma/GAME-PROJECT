using UnityEngine;
using TMPro;
public class CoinCollector : MonoBehaviour
{
    
    private int CoinValue ; // The amount of score added when the coin is collected
    public AudioClip coinSound; // The sound effect to play when the coin is collected
    private AudioSource audioSource; // The audio source to play the sound effect
    public TMP_Text CoinText;
    void OnTriggerEnter(UnityEngine.Collider other)
    {
        if (other.CompareTag("Coins"))
        {
            CoinValue++;
            // Play the coin sound effect
            if (coinSound != null && audioSource != null)
            {
                audioSource.PlayOneShot(coinSound);
            }

            // Destroy the coin GameObject
            Destroy(other.gameObject);
        }


    }
    private void Update()
    {
        CoinText.text = CoinValue.ToString();
    }
}
