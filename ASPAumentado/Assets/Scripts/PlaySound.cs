using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audio1;


    public void MiPlaySound()
    {
        audio1.Play();
    }

    public void MiStopSound()
    {
        audio1.Stop();
    }

}
