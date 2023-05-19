using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideShowSceneMessage : MonoBehaviour
{
    public GameObject findMarkerObj;
    public GameObject findSurfaceObj;
    public GameObject placeObjectObj;

    public bool showFindMarker = false;
    public bool showFindSurface = false;
    public bool showPlaceObject = false;

    // Start is called before the first frame update
    void Start()
    {
        findMarkerObj.SetActive(showFindMarker);
        findSurfaceObj.SetActive(showFindSurface);
        placeObjectObj.SetActive(showPlaceObject);
        
    }

    public void toggleFindMarkerVisibility()
    {
        findMarkerObj.SetActive(!findMarkerObj.activeInHierarchy);
    }

    public void toggleFindSurfaceVisibility()
    {
        findSurfaceObj.SetActive(!findSurfaceObj.activeInHierarchy);
    }

    public void togglePlaceObjectVisibility()
    {
        placeObjectObj.SetActive(!placeObjectObj.activeInHierarchy);
    }


    public void planeDetected()
    {
        placeObjectObj.SetActive(true);
        findSurfaceObj.SetActive(false);
    }




    // Update is called once per frame
    void Update()
    {
        
    }
}