using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reverse : MonoBehaviour
{
    public GameObject loopreverse;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            loopreverse.SetActive(false);
        }
    }
}