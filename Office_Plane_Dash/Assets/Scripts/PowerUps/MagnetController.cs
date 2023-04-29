using UnityEngine;

public class MagnetController : MonoBehaviour
{
    public float magnetStrength = 100f;

    void OnTriggerStay(UnityEngine.Collider other)
    {
        if (other.gameObject.tag == "Coins")
        {
            Vector3 direction = transform.position - other.transform.position;
            float distance = direction.magnitude;
            float force = magnetStrength / distance;
            other.attachedRigidbody.AddForce(direction.normalized * force);
        }
    }
}