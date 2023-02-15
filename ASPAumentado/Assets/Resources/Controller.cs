using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Android;
using TMPro;
using System;

public class Controller : MonoBehaviour
{
    public GameObject canva;
    public GameObject camera;
    public GameObject target;
    bool active = false;
    bool active2 = false;
    public string pathg = "";
    public void encuentra()
    {
        active = true;
        active2 = true;
    }
    public void pierde()
    {
        active = false;
        active2 = false;
    }
    private void Start()
    {
      
       
        camera.SetActive(false);
    }
    private void Update()
    {
        if (active)
        {
            camera.SetActive(true);
           
        }
        else
        {
          camera.SetActive(false);
            
        }
        if (active2 == true)
        {
            canva.SetActive(true);

        }
        else { canva.SetActive(false); }
    }


    public string SSname()
    {
        return string.Format("{0}/photot/screen_{1}.png", pathg, System.DateTime.Now.ToString("yyy-MM-dd_HH-mm-ss"));
    }

    public void TakeHiResShot()
    {active = false;
        camera.SetActive(false);

        StartCoroutine(captureIt2());

    }
    IEnumerator captureIt2()
    {
        yield return new WaitForSeconds(0.4f); ;
        Texture2D ss = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
        ss.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        ss.Apply();
        NativeGallery.Permission permission= NativeGallery.SaveImageToGallery(ss,"photobooth",string.Format("screen_{0}.png", System.DateTime.Now.ToString("yyy-MM-dd_HH-mm-ss")));
        Destroy(ss);
       
        active = true;
    }
}
