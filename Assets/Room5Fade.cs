using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Room5Fade : MonoBehaviour
{
    public Image fade;
    public GameObject image;




    // Start is called before the first frame update
    void Start()
    {

      //  StartCoroutine(ActivationRoutine());
        fade.canvasRenderer.SetAlpha(17f);
        FadeOut();
    }
    void FadeOut()
    {
        fade.CrossFadeAlpha(0, 4.7f, false);
    }
    //private IEnumerator ActivationRoutine()
    //{
    //    //Wait for 14 secs.
    //    yield return new WaitForSeconds(10);

    //    //Turn My game object that is set to false(off) to True(on).
    //    image.SetActive(false);



    }

