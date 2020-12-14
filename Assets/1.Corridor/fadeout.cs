using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fadeout : MonoBehaviour
{
    public AudioSource audio;
    public Image fade;
    public GameObject image;
   

   
    
        // Start is called before the first frame update
        void Start()
    {
        audio.PlayDelayed(1.0f);
        StartCoroutine(ActivationRoutine());
        fade.canvasRenderer.SetAlpha(2f);
        FadeOut();
    }
    void FadeOut()
    {
        fade.CrossFadeAlpha(0, 2, false);
    }
    private IEnumerator ActivationRoutine()
    {
        //Wait for 14 secs.
        yield return new WaitForSeconds(3);

        //Turn My game object that is set to false(off) to True(on).
        image.SetActive(false);



    }


}
