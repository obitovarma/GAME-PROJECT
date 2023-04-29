using UnityEngine;
using UnityEngine.Events;


public class Shield1 : MonoBehaviour
{
    public int requiredCollisions = 2;
    public UnityEvent onCollideTwice;

    private int collisionCount = 0;

    void OnTriggerEnter(UnityEngine.Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            collisionCount++;
            if (collisionCount >= requiredCollisions)
            {
                onCollideTwice.Invoke();
            }
        }
    }
}
