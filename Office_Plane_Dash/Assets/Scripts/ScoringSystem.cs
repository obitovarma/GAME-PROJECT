using UnityEngine;
using TMPro;

public class ScoringSystem : MonoBehaviour
{
    public Transform playerTransform;
    public TMP_Text scoreText;
    public TMP_Text scoreText_crash;
    public TMP_Text scoreText_Pause;
    public TMP_Text scoreText_Complete;
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
        scoreText_crash.text = "Score: " + score.ToString();
        scoreText_Pause.text = "Score: " + score.ToString();
        scoreText_Complete.text = "Score: " + score.ToString();
    }
}
