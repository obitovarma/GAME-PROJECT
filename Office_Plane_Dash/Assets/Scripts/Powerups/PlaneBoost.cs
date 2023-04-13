using UnityEngine;

public class PlaneBoost : MonoBehaviour
{
    public float boostForce = 100f;
    public float boostDuration = 2f;

    private Rigidbody rb;
    private float elapsedBoostTime = 0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            elapsedBoostTime = 0f;
        }
    }

    void FixedUpdate()
    {
        if (elapsedBoostTime < boostDuration)
        {
            // Add upward force
            rb.AddForce(Vector3.up * boostForce, ForceMode.Force);

            elapsedBoostTime += Time.fixedDeltaTime;
        }
    }
}