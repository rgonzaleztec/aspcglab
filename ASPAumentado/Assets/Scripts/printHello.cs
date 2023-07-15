using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class printHello : MonoBehaviour
{
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
        Debug.Log("<color=red>Error: </color>Object Enable");
    }

    private void OnDisable()
    {
        Debug.Log("<color=red>Error: </color>Object Disable");

    }


}
