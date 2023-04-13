using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Collecting_coins : MonoBehaviour
{
    public int coins;

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Coins")
        {
            coins = coins + 1;
            other.gameObject.SetActive(false);
            Destroy(other.gameObject);
            Debug.Log("working");
        }
    }

    
}
