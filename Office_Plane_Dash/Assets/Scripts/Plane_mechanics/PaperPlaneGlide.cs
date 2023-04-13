using UnityEngine;

public class Glide_Mechanics : MonoBehaviour
{
    public float forceMagnitude = 10f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Apply negative force on y-axis
        rb.AddForce(Vector3.down * forceMagnitude, ForceMode.Force);
    }
}