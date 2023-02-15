using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSonidos : MonoBehaviour
{
    // Start is called before the first frame update
    
    public AudioSource buton1;
    public AudioSource buton2;
    public AudioSource buton3;
    public AudioSource buton4;
    public AudioSource buton5;



    public void SonidoBoton1()
    {
        buton1.Play();
    }

    public void SonidoButon2()
    {
        buton2.Play();
    }
    
    public void SonidoButon3()
    {
        buton3.Play();
    }

    public void SonidoButon4()
    {
        buton4.Play();
    }

    public void SonidoButon5()
    {
        buton5.Play();
    }

}
