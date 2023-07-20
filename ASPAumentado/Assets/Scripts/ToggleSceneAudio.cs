using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ToggleSceneAudio : MonoBehaviour
{

    public GameObject playObj;
    public GameObject stopObj;

    private bool isPlaying = true;
    private AudioSource[] audioSources2;
    private List<AudioSource> playingAudioSources = new List<AudioSource>();



    // Start is called before the first frame update
    void Start()
    {
        stopObj.SetActive(true);
        playObj.SetActive(false);

        audioSources2 = Object.FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
        Debug.Log("Audio sources in scene: " + audioSources2.Count());

    }

  



    public void toggleAudioSources()
    {

        
        //IF audios are playing
        if( isPlaying)
        {
            //Store sources in list, stop audios and disebles them so user cant play audios while this option is true
            foreach (AudioSource source in audioSources2)
            {
            
                if (source.isPlaying)
                {
                    playingAudioSources.Add(source);
                    source.Stop();
                }

            }

            if (playingAudioSources.Count > 0)
            {

                foreach(AudioSource source in audioSources2)
                {
                    source.enabled= false;
                }

                isPlaying = !isPlaying;
                stopObj.SetActive(!stopObj.activeInHierarchy);
                playObj.SetActive(!playObj.activeInHierarchy);
            }

        }
        //If audios are not playing (Meaning silence option is active)
        else
        {
            foreach(AudioSource source in audioSources2)
            {
                source.enabled = true;
            }

            foreach(AudioSource source in playingAudioSources)
            {
                source.Play();
            }

            playingAudioSources.Clear();

            isPlaying = !isPlaying;
            stopObj.SetActive(!stopObj.activeInHierarchy);
            playObj.SetActive(!playObj.activeInHierarchy);


        }

    }

/*
    public void toggleAudioSourcesOriginal()
    {

        stopObj.SetActive(!stopObj.activeInHierarchy);
        playObj.SetActive(!playObj.activeInHierarchy);


        if (audioSources.Count > 0)
        {
            foreach (AudioSource source in audioSources)
            {
                if (isPlaying)
                {
                    source.volume = 0;
                    source.Pause();
                }
                else
                {
                    source.volume = 1;
                    source.Play();
                }

            }
        }

        isPlaying = !isPlaying;
    }*/




    // Update is called once per frame
    void Update()
    {
        
    }
}
