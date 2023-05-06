using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Collectibles: MonoBehaviour
{
    public int collectiblesNeeded = 10;
    public AudioClip CollSound;
    public AudioSource audioSource;
    public UnityEvent onCollectiblesCollected1;
    public UnityEvent onCollectiblesCollected2;
    public UnityEvent onCollectiblesCollected3;

    public UnityEvent onCollectiblesCollected4;


    public int collectiblesCollected = 0;

    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        if (other.gameObject.CompareTag("Collectibles"))
        {
            // The player has collided with a collectible
            audioSource.PlayOneShot(CollSound);
            collectiblesCollected++;
            Destroy(other.gameObject);

            if (collectiblesCollected == 1)
            {
                onCollectiblesCollected1.Invoke();
            }
            if (collectiblesCollected ==2)
            {
                onCollectiblesCollected2.Invoke();
            }
            if (collectiblesCollected == 3)
            {
                onCollectiblesCollected3.Invoke();
            }
            if (collectiblesCollected == 4)
            {
                onCollectiblesCollected4.Invoke();
            }
        }
    }
}
