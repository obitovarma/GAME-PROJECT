using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Collider : MonoBehaviour
{
    public UnityEvent Start;
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Start.Invoke();
            
            Debug.Log("Working");
        }


    }
}

    


