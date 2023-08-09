using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopSceneAudio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StopSceneAudioSources()
    {
        AudioSource[] audioSources2 = Object.FindObjectsOfType(typeof(AudioSource)) as AudioSource[];

        foreach (AudioSource source in audioSources2)
        {

            if (source.isPlaying)
            {
                source.Stop();
            }

        }



    }


}
