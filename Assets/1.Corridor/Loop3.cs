using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop3 : MonoBehaviour
{
    public GameObject lampon;
    public GameObject lampoff;
    public GameObject loop2sound;
   
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            lampon.SetActive(false);
            lampoff.SetActive(true);
            loop2sound.SetActive(false);
       
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag=="Player")
        {
            lampon.SetActive(true);
            lampoff.SetActive(false);
        }
    }
}
