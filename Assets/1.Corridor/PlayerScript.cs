using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
   public  Animator anim;


    private void Start()
    {
        //anim = gameObject.GetComponent<Animator>();

    }
 

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Teleport")
        {

            anim.enabled=true;


        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Teleport")
        {

            anim.enabled = false;
        }
    }
}
