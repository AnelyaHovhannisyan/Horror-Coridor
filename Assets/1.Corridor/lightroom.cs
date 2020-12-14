using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lightroom : MonoBehaviour
{
    public GameObject light;
    public GameObject door;
   // public Animator anim;
    public GameObject flower;
    public GameObject tmbushka;
    public GameObject can;
    
 


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
           // canvas.SetActive(false);
           
            door.SetActive(false);
            StartCoroutine(ActivationRoutine());
            door.SetActive(false);


            can.SetActive(true);
            //anim.SetTrigger("Light");
            //anim["Light"].wrapMode = WrapMode.Once;
            //anim.Play("Light");

        }

    }
    private IEnumerator ActivationRoutine()
    {
        //Wait for 14 secs.
        yield return new WaitForSeconds(4.5f);

        //Turn My game object that is set to false(off) to True(on).
        light.SetActive(true);
       
     

    }
}
    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.tag == "Player")
    //    {
    //        anim.SetBool("Light", false);


    //    }
    //}

