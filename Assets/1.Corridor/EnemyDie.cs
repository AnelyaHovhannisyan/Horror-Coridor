using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDie : MonoBehaviour
{
    public GameObject light;
    public GameObject enemy2;
    public GameObject room;
    public GameObject enemy;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            light.SetActive(true);
            enemy2.SetActive(true);
            room.SetActive(true);
            enemy.SetActive(false);
        }
    }
}
