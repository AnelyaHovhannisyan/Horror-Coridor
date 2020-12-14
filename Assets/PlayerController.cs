using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controllerPlayer;
    public float speed = 10f;
    public float speedRotation = 10f;
    // Start is called before the first frame update
    void Start()
    {
        controllerPlayer = GetComponent<CharacterController>();
    }

    // Update is called once per frame

    Vector3 look;
    Vector3 mov;
    void Update()
    {
         mov = new Vector3(SimpleInput.GetAxis("Horizontal") * speed, 0, SimpleInput.GetAxis("Vertical") * speed);
        controllerPlayer.Move(mov * Time.deltaTime);
    }
}
