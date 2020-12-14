using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newdoor : MonoBehaviour
{
    public AudioSource close;
    public bool closed;
    public Animator anim;

   

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


        }
    }

}
