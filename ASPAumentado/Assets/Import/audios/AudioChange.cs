using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudiosChange : MonoBehaviour
{

    public AudioSource myaudio;

    public void Start()
    {
        myaudio.enabled = false;
    }

    public void PlayAudioUno()
    {
        myaudio.enabled = true;
        myaudio.Play();
    }

    public void StopAudioUno()
    {
        myaudio.enabled = false;
        myaudio.Stop();
    }

}
