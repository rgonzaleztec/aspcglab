using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Vuforia;
public class ARManagerGPS : MonoBehaviour
{
    public PlaneFinderBehaviour finder;

    ContentPositioningBehaviour contentPositioningBehaviour;
    AnchorBehaviour planeAnchor, midAirAnchor, placementAnchor;

    float touchesPrePosDifference, touchesCurPosDifference, zoomModifier;
    Vector2 Test, firstTouchPrevPos, secondTouchPrevPos;
    public GameObject obj; // The 3d model that we want to show on the position
    public bool ShowModelState = false;
    public bool CanSupport = false;
    private string consoleString; // Current value of message in console
    public void LaunchModel()
    {
        finder.PerformHitTest(Test);
        ShowModel();
    }
    public void ShowModel()
    {
        obj.SetActive(true);
        ShowModelState = true;
    }
    public void HideModel()
    {
        obj.SetActive(false);
        ShowModelState = false;
    }
    public void ResetTrackers()
    {
        VuforiaBehaviour.Instance.DevicePoseBehaviour.enabled = false;
        VuforiaBehaviour.Instance.DevicePoseBehaviour.Reset();
        VuforiaBehaviour.Instance.DevicePoseBehaviour.enabled = true;

    }
    private void OnEnable()
    {
        Application.logMessageReceived += HandleLog;
    }
    private void OnDisable()
    {
        Application.logMessageReceived -= HandleLog;
    }
    void HandleLog(string message, string stacktrace, LogType type)
    {
        consoleString = consoleString + "\n" + message;
        if (consoleString.Contains("SmartTerrain failed"))
        {
            CanSupport = false;
            print("No, This device can't support the surface tracking");
        }
        else
        {
            CanSupport = true;
            print("Yes, This device can support the surface tracking");
        }
    }
}
