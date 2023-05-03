using UnityEngine;
using TMPro;
public class CoinCollector : MonoBehaviour
{
    
    private int CoinValue ; 
    public AudioClip coinSound; 
    public AudioSource audioSource;
    public TMP_Text CoinText;
    void OnTriggerEnter(UnityEngine.Collider other)
    {
        if (other.CompareTag("Coins"))
        {
            CoinValue++;
            
            if (coinSound != null && audioSource != null)
            {
                audioSource.PlayOneShot(coinSound);
            }

           
            Destroy(other.gameObject);
        }


    }
    private void Update()
    {
        CoinText.text = CoinValue.ToString();
    }
}
