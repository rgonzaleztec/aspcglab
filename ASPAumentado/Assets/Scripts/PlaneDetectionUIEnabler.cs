using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class PlaneDetectionUIEnabler : MonoBehaviour
{
    public GameObject planeFinderObject;
    public GameObject button;
    public GameObject planeStageObject;
  



    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void resetPlaneDetection()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        /**
        if (planeFinderObject != null )
        {
            planeFinderObject.SetActive(true);
            button.SetActive(false);
            planeStageObject.SetActive(false);
        }
        */
    }
}
