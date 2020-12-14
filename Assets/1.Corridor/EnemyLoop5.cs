using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

public class EnemyLoop5 : MonoBehaviour
{
    public AudioSource audio;
    private float timer = 30f;
    public GameObject camera;
    public GameObject play;
    public Animator anim;
    public float delay = 5f;
    public string NewLevel;
    public Transform player;
    //At what distance will the enemy walk towards the player?
    public float walkingDistance = 10.0f;
    //In what time will the enemy complete the journey between its position and the players position
    public float smoothTime = 10.0f;
    //Vector3 used to store the velocity of the enemy
    private Vector3 smoothVelocity = Vector3.zero;
    //Call every frame
    void Update()
    {
        //Look at the player
        transform.LookAt(player);
        //Calculate distance between player
        float distance = Vector3.Distance(transform.position, player.position);
        //If the distance is smaller than the walkingDistance
        if (distance < walkingDistance)
        {
            //Move the enemy towards the player with smoothdamp
            transform.position = Vector3.SmoothDamp(transform.position, player.position, ref smoothVelocity, smoothTime);
        }
    }



IEnumerator LoadLevelAfterDelay(float delay)
{
    yield return new WaitForSeconds(delay);
    SceneManager.LoadScene(NewLevel);
}

private void OnTriggerEnter(Collider other)
{
    if (other.tag == "Player")
    {

            audio.Play();
            anim.SetBool("Catch", true);
        camera.SetActive(true);
        StartCoroutine(LoadLevelAfterDelay(delay));


    }

}
}

