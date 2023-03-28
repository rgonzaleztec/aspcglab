using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
public class GPSCore : MonoBehaviour
{
    public TextMeshProUGUI texto;
    public TextMeshProUGUI texto2;
    public double[] Lat;
    public double[] Lon;
    internal int PointCounter = 0; // the amount of points that we want to check in GPS process
    private double distance;
    private Vector3 TargetPosition;
    private Vector3 OriginalPosition;
    public float Radius = 5f; // Range of Target function start
    public float TimeUpdate = 3f; // Time of compare current coordinates with target per second
    private string newlat;
    private string newlon;
    float lat;
    float lon;
    public GameObject[] PointObjects; // The list of objects for every points that we want to show
    public GameObject[] TargetPopUp; // the popup UI pages when the user reach the target position
    public bool TargetPupUpOneTime = false; // for check the popup appear one time not everytime when we are in the range of target
    public UnityEvent EventStartGPS; // This event will work when the GPS system start to work
    public UnityEvent EventReachGPSPoint; // This event will work when player reached the GPS point
    public UnityEvent EventOutGPSPointRange; // This event will work when player is out of the GPS point range
    public GameObject NoGPSPopUp; // the popup UI page when the user's device location is off
    public bool NoGPSPupUpOneTime = false; // for check the popup appear one time not everytime

    

    private void Start()
    {
        // Call the GPS connection in native and try to connect to the satelite
        Input.location.Start();
        StartCoroutine("GPSProcess");
        if (EventStartGPS != null)
        {
            EventStartGPS.Invoke();
        }
       
        //this.texto.SetText("HOLA, AMIGES");
    }
    public IEnumerator GPSProcess()
    {
        while (true)
        {
            yield return new WaitForSeconds(TimeUpdate);
            if (Input.location.isEnabledByUser == true)
            {
                Input.location.Start();
                lat = Input.location.lastData.latitude;
                newlat = lat.ToString();
                lon = Input.location.lastData.longitude;
                newlon = lon.ToString();
                Calc(Lat[PointCounter], Lon[PointCounter], lat, lon);

               
            }
            if (Input.location.isEnabledByUser == false && NoGPSPupUpOneTime == false)
            {
                NoGPSPopUp.SetActive(true);
                TargetPupUpOneTime = true;
            }
        }
    }
    public void Calc(double lat1, double lon1, double lat2, double lon2)
    {
        this.texto.SetText("(lat1,long1)(" + lat1 + "," +lon1 + ")\n(lat2,long2)" + lat2 + "," + lon2+")");


        var R = 6378.137; // Radius of earth in KM
        var dLat = lat2 * Mathf.PI / 180 - lat1 * Mathf.PI / 180;
        var dLon = lon2 * Mathf.PI / 180 - lon1 * Mathf.PI / 180;
        
        double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
            Math.Cos(lat1 * Math.PI / 180) * Math.Cos(lat2 * Math.PI / 180) *
            Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
        var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
        distance = R * c;
        distance = distance * 1000f;
        float distanceFloat = (float)distance;
        TargetPosition = OriginalPosition - new Vector3(0, 0, distanceFloat * 12);
        if (distance < Radius)
        {
            this.texto2.SetText("Dentro del rango");
            if (TargetPupUpOneTime == false)
            {
                for (int i = 0; i < TargetPopUp.Length; i++)
                {
                    TargetPopUp[i].SetActive(false);
                    PointObjects[i].SetActive(false);
                }
                TargetPopUp[PointCounter].SetActive(true);
                PointObjects[PointCounter].SetActive(true);
                
                if (EventReachGPSPoint != null)
                {
                    EventReachGPSPoint.Invoke();
                }
            }
        }
        if (distance > Radius)
        {
            this.texto2.SetText("Fuera del rango");
            for (int i = 0; i < TargetPopUp.Length; i++)
            {
                TargetPopUp[i].SetActive(false);
                PointObjects[i].SetActive(false);
                
            }
            PointCounter++;
            if (PointCounter == Lat.Length)
            {
                PointCounter = 0;
            }
            if (EventOutGPSPointRange != null)
            {
                EventOutGPSPointRange.Invoke();
            }
        }
    }
    public void HideTargetPopUp()
    {
        TargetPopUp[PointCounter].SetActive(false);
        PointObjects[PointCounter].SetActive(false);
        TargetPupUpOneTime = true;
    }
    public void HideNoGPSPopUp()
    {
        NoGPSPopUp.SetActive(false);
    }
}