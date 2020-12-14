using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour
{
    public GameObject player;
    public AudioSource radio1;
 
   
   private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            radio1.Play();
            

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            radio1.Stop();
            

        }
    }
}
