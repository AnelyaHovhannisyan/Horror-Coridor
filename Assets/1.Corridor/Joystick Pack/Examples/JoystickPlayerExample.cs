using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class JoystickPlayerExample : MonoBehaviour
{
    public GameObject hellcorridor;
    public float moveSpeed;
    public float camTurnSpeed;
    public VariableJoystick variableJoystick;
    public VariableJoystick cameraJoistick;
    public Rigidbody rb;
    public AudioSource audioSource1;
    public AudioSource audioSource2;
    private AudioSource footsteps;
    public GameObject walk;



    public void Awake()
    {
        footsteps = audioSource1;
        Application.targetFrameRate = 60;

    }
    public void FixedUpdate()
    {

        var w = variableJoystick.Vertical * Time.fixedDeltaTime * moveSpeed;
        var y = variableJoystick.Horizontal * Time.fixedDeltaTime * moveSpeed;
        var x = cameraJoistick.Horizontal * Time.fixedDeltaTime * camTurnSpeed;
       // transform.Rotate(0, x, 0);
        rb.MovePosition(rb.position + (transform.forward * w + transform.right * y));

        look.x = Mathf.Clamp(look.x, -48f, 70f);




        if (variableJoystick.Vertical != 0 || variableJoystick.Horizontal != 0)
        {
            // audioSource.Play();
        }
        else
        {
            footsteps.Play();
        }
    }


    private Vector3 offset;
    
    [SerializeField] float speedRotation = 10;
    Vector3 look;
    [SerializeField]float limit;
    void Update()
    {
        
      //  look = new Vector3(SimpleInput.GetAxis("Vertical_2") * -speedRotation * Time.deltaTime, SimpleInput.GetAxis("Horizontal_2") * speedRotation * Time.deltaTime, 0);
       
       // transform.localEulerAngles += look;

       



    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hell")
        {
            footsteps.Stop();
            SwapAudioSources();
        }
        if (other.tag == "Walk")
        {
            footsteps.Stop();
            Awake();
            
        }

    }
    
 

    public void SwapAudioSources()
    {
        footsteps = audioSource2;
    }
    


    PointerEventData pointerData;

    bool isDragging = false;
    Vector2 StartPosition;
    Vector2 CurrentPosition;
    public static Vector2 TotalDeltaPosition;
    Vector2 LastPosition;
    public static Vector2 DeltaPosition;


    public void TouchDrag(BaseEventData data)
    {
        pointerData = data as PointerEventData;

        isDragging = true;

        CurrentPosition = pointerData.position;

        TotalDeltaPosition = CurrentPosition - StartPosition;
        DeltaPosition = CurrentPosition - LastPosition;

        LastPosition = pointerData.position;
        
        look += new Vector3(DeltaPosition.y * -speedRotation,DeltaPosition.x * speedRotation , 0);
        

        transform.localEulerAngles = look;
        
    }

    public void TouchDown(BaseEventData data)
    {
        pointerData = data as PointerEventData;

        StartPosition = pointerData.position;
        LastPosition = StartPosition;
        TotalDeltaPosition = Vector3.zero;
        DeltaPosition = Vector3.zero;
  



    }


    public void TouchUp()
    {
        isDragging = false;
        TotalDeltaPosition = Vector3.zero;
        DeltaPosition = Vector3.zero;


    }


}