using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    public Animator anim;
    public GameObject player;
    public AudioSource close;
    public GameObject text;
    public bool closed;

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

            text.SetActive(false);


        }
    }
}



