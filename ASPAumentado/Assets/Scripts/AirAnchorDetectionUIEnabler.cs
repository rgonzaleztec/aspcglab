using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class AirAnchorDetectionUIEnabler : MonoBehaviour
{
    public GameObject airAnchorFinderObject;
    public GameObject button;
    public GameObject airAnchorStageObject;
  



    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void resetAirAnchorDetection()
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
