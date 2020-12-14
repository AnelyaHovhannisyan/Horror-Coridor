using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    public GameObject sounds;
    public GameObject enemy;
    public AudioClip SoundToPlay;
    public float Volume;
    AudioSource audio;
    public bool alreadyPlayed = false;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            sounds.SetActive(true);

            enemy.SetActive(true);
            if (!alreadyPlayed)
            {

                audio.PlayOneShot(SoundToPlay, Volume);
                alreadyPlayed = true;
            }
        }
    }
}