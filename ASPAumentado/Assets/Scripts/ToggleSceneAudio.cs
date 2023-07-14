using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSceneAudio : MonoBehaviour
{

    public GameObject playObj;
    public GameObject stopObj;
    private bool isPlaying = true;

    public List<AudioSource> audioSources;

    private AudioSource[] audioSources2; 



    // Start is called before the first frame update
    void Start()
    {
        stopObj.SetActive(true);
        playObj.SetActive(false);
        
        audioSources2 = Object.FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
        Debug.Log("Audio sources in scene: " + audioSources2);
    }

    public void toggleAudioSources()
    {
        stopObj.SetActive( !stopObj.activeInHierarchy );
        playObj.SetActive( !playObj.activeInHierarchy );

        if(audioSources.Count > 0)
        {
           

            foreach (AudioSource source in audioSources)
            {
                if(isPlaying)
                {
                    source.Stop();
                }
                else
                {
                    source.Play();
                }
                
            }
        }

        isPlaying = !isPlaying;
    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
