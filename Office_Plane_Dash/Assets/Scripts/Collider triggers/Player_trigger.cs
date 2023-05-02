using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player_trigger : MonoBehaviour
{
    public UnityEvent Start;
    void OnTriggerEnter(UnityEngine.Collider other)
    {
        if (other.gameObject.tag == "Obstacles")
        {
            Start.Invoke();


        }
    }



}
