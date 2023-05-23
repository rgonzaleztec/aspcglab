using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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


        if (planeFinderObject != null )
        {
            planeFinderObject.SetActive(true);
            button.SetActive(false);
            planeStageObject.SetActive(false);
        }
    }
}
