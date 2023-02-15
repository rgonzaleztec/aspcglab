using UnityEngine;

public class playvideo : MonoBehaviour
{

    public new AudioSource audio;



    public void Ejecutarvideo()
    {

        audio.Play();
    }

    public void StopVideo()
    {
        audio.Stop();
    }
}
