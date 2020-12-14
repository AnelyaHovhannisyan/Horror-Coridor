using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door2: MonoBehaviour
{

    public AudioSource audio1;
    public AudioSource audio2;

    public AudioSource close;
    public bool closed;
    public Animator anim;
    public GameObject audio;
   

    public GameObject Text;

    public GameObject player;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            audio1.Play();
            audio2.Play();

           
            audio.SetActive(false);

            if (!closed)
            {
                anim.SetBool("Open", false);
                close.Play();

                closed = true;

            }

            Text.SetActive(false);
   

        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {


        }
    }
}
