using UnityEngine;
using TMPro;

public class CoinCount : MonoBehaviour
{
    public TextMeshProUGUI coinCountText;
    private int coinsCollected = 0;
    private int totalCoins = 0;

    void Start()
    {
        // Get the total number of coins in the scene
        GameObject[] coins = GameObject.FindGameObjectsWithTag("Coins");
        totalCoins = coins.Length;

        // Update the UI with the initial values
        UpdateUI();
    }

    public void CollectCoin()
    {
        coinsCollected++;
        UpdateUI();

        // Check if all coins have been collected
        if (coinsCollected >= totalCoins)
        {
            // Do something when all coins have been collected
            Debug.Log("All coins collected!");
        }
    }

    private void UpdateUI()
    {
        coinCountText.text = "Coins: " + coinsCollected.ToString() + " / " + totalCoins.ToString();
    }
}
