//Referencia https://github.com/yasirkula/UnityNativeGallery

using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Android;
using TMPro;
using System;

public class Controller : MonoBehaviour
{
    //public GameObject canvas;
    public List<GameObject> hide_Elements;



    //public GameObject cameraBtn;
    //public GameObject target;
    //bool active = true;
    // active2 = false;
    public string pathg = "";
    public string experienceTitle = "PhotoBooth";

    
    private void hideShowElements()
    {
        if(hide_Elements.Count != 0)
        {
            foreach (GameObject element in hide_Elements)
            {
                //Se activan o desactivan los elementos
                element.SetActive(!element.activeInHierarchy);
            }
        }
    }


    private void Start()
    {
    }
    private void Update()
    {
       
    }


    public string SSname()
    {
        return string.Format("{0}/photot/screen_{1}.png", pathg, System.DateTime.Now.ToString("yyy-MM-dd_HH-mm-ss"));
    }

    public void TakeHiResShot()
    {
        hideShowElements();
        StartCoroutine(captureIt2());

    }

    WaitForSeconds waitTime = new WaitForSeconds(0.1F);
    WaitForEndOfFrame frameEnd = new WaitForEndOfFrame();

    private IEnumerator captureIt2()
    {
        yield return waitTime;
        yield return frameEnd;

        Texture2D ss = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
        ss.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        ss.Apply();
       
        NativeGallery.Permission permission = NativeGallery.SaveImageToGallery(ss, "Arenal_Volcano_National_Park_AR", string.Format("{0}-{1}.png", experienceTitle, System.DateTime.Now.ToString("yyy-MM-dd_HH-mm-ss")) , (success, path) => Debug.Log("Media save result: " + success + " " + path));

        Debug.Log("Permission result: " + permission);
        Destroy(ss);

        hideShowElements();
    }
}
