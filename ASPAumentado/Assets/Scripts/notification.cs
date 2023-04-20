using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notification : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void showNotification()
    {
        gameObject.SetActive(true);

    }

    public void hideNotification()
    {
        gameObject.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
