using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        // Calculate the rotation amount based on the rotation speed
        float rotationAmount = rotationSpeed * Time.deltaTime;

        // Rotate the coin on its local y-axis
        transform.Rotate(0f, rotationAmount, 0f, Space.Self);
    }
}

