using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Boost_up : MonoBehaviour
{
    // Attach this script to the powerup object

    // Set this value in the editor to determine the strength of the boost
    public float boostStrength = 10f;

    // This is the duration of the boost effect in seconds
    public float boostDuration = 2f;

    // This variable keeps track of whether the powerup has been collected
    private bool collected = false;

    // This is a reference to the player object
    public GameObject player;

    void OnTriggerEnter(UnityEngine.Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            collected = true;
            player = other.gameObject;
            StartCoroutine(BoostPlayer());
        }
    }

    IEnumerator BoostPlayer()
    {
        // Apply the boost effect
        player.GetComponent<Rigidbody>().AddForce(Vector3.up * boostStrength, ForceMode.Impulse);

        // Wait for the duration of the boost effect
        yield return new WaitForSeconds(boostDuration);

        // Reset the player's velocity
        player.GetComponent<Rigidbody>().velocity = Vector3.zero;
        // Destroy the powerup object
        Destroy(gameObject);
    }

}

