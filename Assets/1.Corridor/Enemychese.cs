using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Enemychese : MonoBehaviour
{
    public Transform player;
    //At what distance will the enemy walk towards the player?
    public float walkingDistance = 5.0f;
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
    // public float lookRadius = 10f;
    //public  Transform target;
    //public  NavMeshAgent nav;
    // // Start is called before the first frame update
    // void Start()
    // {

    //     nav = GetComponent<NavMeshAgent>();

    // }

    // // Update is called once per frame
    // void Update()
    // {
    //     float distance = Vector3.Distance(target.position, transform.position);
    //     if(distance<=lookRadius)
    //     {
    //         nav.SetDestination(target.position);

    //     }

    // }
    // private void OnDrawGizmosSelected()
    // {
    //     Gizmos.color = Color.red;
    //     Gizmos.DrawWireSphere(transform.position, lookRadius);
    // }
}
