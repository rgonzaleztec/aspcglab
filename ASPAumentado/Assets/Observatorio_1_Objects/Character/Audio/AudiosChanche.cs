using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudiosChanche : MonoBehaviour
{

    public AudioSource myaudio;

    public void Start(){
        myaudio.enabled = false;
    }

    public void PlayUdioUno()
    {
        myaudio.enabled = true;
        myaudio.Play();
    }

    public void PauseAudio()
    {
        myaudio.Pause();
    }

    public void StopAudioUno()
    {
        myaudio.enabled = false;
        myaudio.Stop();
    }

}
