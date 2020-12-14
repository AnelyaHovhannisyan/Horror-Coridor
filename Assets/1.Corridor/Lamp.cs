using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{
    public Animator anim;
    private void OnTriggerEnter(Collider other)
    {
        
    
          if (other.tag == "Player")
        {
            anim.SetBool("Light", true);
          
       
            
        }
    }
    private void OnTriggerExit(Collider other)
{
    if (other.tag == "Player")
    {
        anim.SetBool("Light", false);
    }
}
}
