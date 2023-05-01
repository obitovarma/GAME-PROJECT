using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Trigger_Magnet : MonoBehaviour
{
    public float destroyDelay = 2f; // Delay before destroying the object
    public GameObject object1;
    public UnityEvent Start;

    void OnTriggerEnter(UnityEngine.Collider other)
    {
        if (other.gameObject.tag == "Coins")
        {
            Start.Invoke();
            
            StartCoroutine(DestroyAfterDelay(other.gameObject));
        }
    }

    IEnumerator DestroyAfterDelay(GameObject gameObjectToDestroy)
    {
        yield return new WaitForSeconds(destroyDelay);
        object1.SetActive(false);
    }
}
