using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenClose : MonoBehaviour
{
   
   //public GameObject corridorreverse;
  
    public GameObject door;
   // public GameObject corridor5;
    //public GameObject dooropen;
    //public GameObject doorclose;
    public GameObject player;
    public GameObject loop3;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
        
           
          // corridorreverse.SetActive(false);
            door.SetActive(false);
           // corridor5.SetActive(true);
            loop3.SetActive(false);
            //dooropen.SetActive(true);
            //doorclose.SetActive(false);
            
        }
    }
}
