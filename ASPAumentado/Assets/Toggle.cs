using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggle : MonoBehaviour
{
    [SerializeField] private GameObject background;
    [SerializeField] private radio radioScript;
    [SerializeField] private AudioClip corecto;
    [SerializeField] private AudioClip incorrecto;

    // Start is called before the first frame update
    void Start()
    {
        radioScript = transform.parent.transform.GetComponent<radio>();
        //backgraund es el primer hijo de this
        background = transform.GetChild(0).gameObject;
    }

    public void clickRadio()
    {
        //verificar si fue seleccionado el toggle
        if (gameObject.GetComponent<UnityEngine.UI.Toggle>().isOn)
        {
            //si name es igual a bird, entonces activar background
            if (radioScript.bird == gameObject.name)
            {
                //cambiar color a Image de background
                background.GetComponent<UnityEngine.UI.Image>().color = new Color(0, 255, 0, 1);
                //cambiar audioclip de audiosurce
                gameObject.GetComponent<AudioSource>().clip = corecto;
                //reproducir audio
                gameObject.GetComponent<AudioSource>().Play();
                Debug.Log("Correcto");
                //reiniciar 
                radioScript.reSelection();
                StartCoroutine(reestartColor());
            }
            else
            {
                //cambiar color a Image de background a rojo
                background.GetComponent<UnityEngine.UI.Image>().color = new Color(255, 0, 0, 1);
                 //cambiar audioclip de audiosurce
                gameObject.GetComponent<AudioSource>().clip = incorrecto;
                //reproducir audio
                gameObject.GetComponent<AudioSource>().Play();
                Debug.Log("Incorrecto");
                //llamat co rutina para volver color negro en 2 segundos
                StartCoroutine(reestartColor());
            }
        }

        
    }

    //corutina para reinixar color en 2 segundos
    private IEnumerator reestartColor()
    {
        // Código antes de la pausa

        yield return new WaitForSeconds(2.0f); // Pausa de 2 segundos

        // Código después de la pausa
        background.GetComponent<UnityEngine.UI.Image>().color = new Color(0, 0, 0, 1);
    }
}
