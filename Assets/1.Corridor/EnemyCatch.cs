using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyCatch : MonoBehaviour
{

   
    private float timer = 30f;
    public GameObject camera;
    public GameObject audio1;
  
    public Animator anim;
    public AudioSource audio;
    public float delay = 5f;
    public string NewLevel;
    void Start()
    {
        
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
            audio1.SetActive(false);
         
            anim.SetBool("Catch", true);
            camera.SetActive(true);
            StartCoroutine(LoadLevelAfterDelay(delay));


        }

    }
    

}
