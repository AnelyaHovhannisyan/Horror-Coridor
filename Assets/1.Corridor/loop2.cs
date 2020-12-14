using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loop2 : MonoBehaviour
{
    public GameObject loop1;
    public GameObject Loop2;
    public GameObject player;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            Loop2.SetActive(true);
            loop1.SetActive(false);



        }
    }
}
