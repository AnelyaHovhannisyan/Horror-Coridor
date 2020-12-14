using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorScript : MonoBehaviour
{
   
    public AudioSource open;
  
    public Animator anim;
    public GameObject Text;
    public bool closed;
    public bool m_solved = false;
    private void Start()
    {
        closed = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
          
            Text.SetActive(true);
         
            

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag=="Player")
        {

            Text.SetActive(false);


        }
    }
    private bool OpenMeow
    {
        get
        {
            return Text.activeInHierarchy;
        }
         
    }


    public void OpenDoor()
    { 
       
        {
            if (closed)
            {
                
                anim.SetBool("Open", true);
                closed = false;
                open.Play();
            }
       

        }
    }
 
}
