using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CNCierreSingleton : MonoBehaviour
{

    public CNCierreImageGuideManager behaviour = null;

    public static CNCierreSingleton Instance { get; private set; }

    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
}



