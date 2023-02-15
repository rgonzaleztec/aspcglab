using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audio;


    public void MiPlaySound()
    {
        audio.Play();
    }

    public void MiStopSound()
    {
        audio.Stop();
    }

}
