using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomCoridor : MonoBehaviour
{
    public GameObject dooropen;
    public GameObject doorclose;
    public GameObject playeranim;
    public GameObject enemy;
    public GameObject room;
    public GameObject Corridor;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            dooropen.SetActive(true);
            doorclose.SetActive(false);
            playeranim.SetActive(false);
            enemy.SetActive(true);
            room.SetActive(true);
            Corridor.SetActive(false);
        }
    }
}
