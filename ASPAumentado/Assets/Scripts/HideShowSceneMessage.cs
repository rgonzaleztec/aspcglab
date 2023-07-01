using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideShowSceneMessage : MonoBehaviour
{
    public GameObject findMarkerObj;
    public GameObject findSurfaceObj;
    public GameObject findAirAnchor;
    public GameObject placeObjectObj;
    public GameObject placeAirObject;


    public bool showFindMarker = false;
    public bool showFindSurface = false;
    public bool showFindAirAnchor = false;
    public bool showPlaceObject = false;
    public bool showPlaceAirObject = false;


    // Start is called before the first frame update
    void Start()
    {
        findMarkerObj.SetActive(showFindMarker);
        findSurfaceObj.SetActive(showFindSurface);
        findAirAnchor.SetActive(showFindAirAnchor);

        placeObjectObj.SetActive(showPlaceObject);
        placeAirObject.SetActive(showPlaceAirObject);


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

    public void toggleAirAnchorVisibility()
    {
        findAirAnchor.SetActive(!findAirAnchor.activeInHierarchy);
    }
    public void togglePlaceAirObjectVisibility()
    {
        placeAirObject.SetActive(!placeAirObject.activeInHierarchy);
    }

   


    public void planeDetected()
    {
        placeObjectObj.SetActive(true);
        findSurfaceObj.SetActive(false);
    }

    public void airAnchorDetected()
    {
        placeAirObject.SetActive(true);
        findAirAnchor.SetActive(false);
    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
