using UnityEngine;

public class MoveVehicle : MonoBehaviour
{
    public float speed = 10.0f; // The speed at which the vehicle moves
    public float destroyDelay = 5.0f; // The time delay before the car is destroyed

    void Start()
    {
        Invoke("DestroyGameObject", destroyDelay); // Invoke the DestroyGameObject() method after the delay
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime); // Moves the vehicle forward
    }

    void DestroyGameObject()
    {
        Destroy(gameObject); // Destroy the car GameObject
    }
}
