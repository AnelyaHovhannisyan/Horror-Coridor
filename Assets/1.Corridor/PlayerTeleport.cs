using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{

    
    public AudioSource close;
    public bool closed;
    public Animator anim;
    public GameObject room;
    public GameObject cooridor;

    public GameObject Text;

    public GameObject player;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            
            
            if (!closed)
            {
                anim.SetBool("Open", false);
                close.Play();

                closed = true;

            }

            Text.SetActive(false);
            cooridor.SetActive(true);
            room.SetActive(false);

        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            
        }
    }
}
