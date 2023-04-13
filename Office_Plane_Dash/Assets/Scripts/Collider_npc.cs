using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Collider_npc : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
       
        if (other.gameObject.tag == "Npc")
        {
            Destroy(other.gameObject);
        }
    }

}

