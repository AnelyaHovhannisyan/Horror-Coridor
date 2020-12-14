using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loop4corridors : MonoBehaviour
{
    public GameObject loop5;
    public GameObject corridor;
    public GameObject corridor5;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            loop5.SetActive(true);
            corridor.SetActive(false);
            corridor5.SetActive(true);


        }
    }
}