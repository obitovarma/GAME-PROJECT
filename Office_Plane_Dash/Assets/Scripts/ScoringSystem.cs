using UnityEngine;
using TMPro;

public class ScoringSystem : MonoBehaviour
{
    public Transform playerTransform;
    public TMP_Text scoreText;
    public float scoreMultiplier = 1f;

    private float startingZ;
    private float distanceTravelled;
    private int score;

    void Start()
    {
        startingZ = playerTransform.position.z;
    }

    void Update()
    {
        // Calculate distance travelled
        distanceTravelled = Mathf.Abs(playerTransform.position.z - startingZ);

        // Update score based on distance travelled
        score = Mathf.RoundToInt(distanceTravelled * scoreMultiplier);

        // Update score display
        scoreText.text = "Score: " + score.ToString();
    }
}
