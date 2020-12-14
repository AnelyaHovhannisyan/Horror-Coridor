using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loop2sound : MonoBehaviour
{
    public GameObject door1;
    public GameObject door;
    public GameObject loop3;
 public AudioClip SoundToPlay;
 public float Volume;
 AudioSource audio;
public bool alreadyPlayed = false;
void Start()
{
    audio = GetComponent<AudioSource>();
}

void OnTriggerEnter()
{
        loop3.SetActive(true);
        door1.SetActive(false);
        door.SetActive(true);
    if (!alreadyPlayed)
    {
            
        audio.PlayOneShot(SoundToPlay, Volume);
        alreadyPlayed = true;
    }
}
}
