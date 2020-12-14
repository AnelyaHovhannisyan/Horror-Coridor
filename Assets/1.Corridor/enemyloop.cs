using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyloop : MonoBehaviour
{
   
    public GameObject enemy;
    public GameObject loopcorridor;
    public GameObject door4;
    public GameObject corridor4;
    public GameObject corridorreverse;
    public GameObject loop4;
    public GameObject dooropen;
    public GameObject doorclose;
    public GameObject player;
    public GameObject loop2sound;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            
            enemy.SetActive(true);
            loopcorridor.SetActive(true);
           door4.SetActive(false);
            corridor4.SetActive(true);
            corridorreverse.SetActive(false);
            loop4.SetActive(true);
            dooropen.SetActive(true);
            doorclose.SetActive(false);
            loop2sound.SetActive(false);
        }
    }
}
