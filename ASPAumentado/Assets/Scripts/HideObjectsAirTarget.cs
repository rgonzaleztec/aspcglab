using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideObjectsAirTarget : MonoBehaviour
{

    public GameObject PlaceObject;
    public GameObject FindingAirAnchor;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        Debug.Log("Object Enable");
        PlaceObject.SetActive(true);
        FindingAirAnchor.SetActive(false);
    }

    private void OnDisable()
    {
        Debug.Log("Object Disable");
        PlaceObject.SetActive(false);
        FindingAirAnchor.SetActive(true);

    }
}
