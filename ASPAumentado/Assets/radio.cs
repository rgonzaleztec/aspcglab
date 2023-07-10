using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class radio : MonoBehaviour
{
    //array con nombre de 4 apajaros
    private string[] birds = new string[7];
    public string bird;
    private string birdAnt = "";
    [SerializeField] private AudioClip jabiru;
    [SerializeField] private AudioClip ibisVerde;
    [SerializeField] private AudioClip espatulaRosa;
    [SerializeField] private AudioClip jacana;
    [SerializeField] private AudioClip lechucita;
    [SerializeField] private AudioClip loro;
    [SerializeField] private AudioClip tucan;
    [SerializeField] private AudioClip audioCorrecto;
    //textMesh pro gui text
    [SerializeField] public TextMeshProUGUI textMesh;

    public void startGame()
    {
        birds[0] = "Jabiru";
        birds[1] = "Ibis Verde";
        birds[2] = "Espátula Rosada";
        birds[3] = "Jacana";
        birds[4] = "Lechucita Sabanera";
        birds[5] = "Loro Frentirrojo";
        birds[6] = "Tucán Pico Iris";
        Debug.Log("Start Game: " + birds.Length);

        
        bird = birds[Random.Range(0, 7)];
        birdAnt = bird;
            

        if(bird=="Jabiru")
        {
            audioCorrecto = jabiru;
        }
        else if(bird=="Ibis Verde")
        {
            audioCorrecto = ibisVerde;
        }
        else if(bird=="Espátula Rosada")
        {
            audioCorrecto = espatulaRosa;
        }
        else if(bird=="Jacana")
        {
            audioCorrecto = jacana;
        }
        else if(bird=="Lechucita Sabanera")
        {
            audioCorrecto = lechucita;
        }
        else if(bird=="Loro Frentirrojo")
        {
            audioCorrecto = loro;
        }
        else if(bird=="Tucán Pico Iris")
        {
            audioCorrecto = tucan;
        }
        gameObject.GetComponent<AudioSource>().clip = audioCorrecto;
        gameObject.GetComponent<AudioSource>().Play();
        StartCoroutine(atencionMsj());
        
    }

    public void reSelection()
    {
        StartCoroutine(cambioMsj2());

        while(true){
            bird = birds[Random.Range(0, 7)];
            if(bird != birdAnt){
                birdAnt = bird;
                break;
            }
        }
        if(bird=="Jabiru")
        {
            gameObject.GetComponent<AudioSource>().clip = jabiru;
        }
        else if(bird=="Ibis Verde")
        {
            gameObject.GetComponent<AudioSource>().clip = ibisVerde;
        }
        else if(bird=="Espátula Rosada")
        {
            gameObject.GetComponent<AudioSource>().clip = espatulaRosa;
        }
        else if(bird=="Jacana")
        {
            gameObject.GetComponent<AudioSource>().clip = jacana;
        }
        else if(bird=="Lechucita Sabanera")
        {
            gameObject.GetComponent<AudioSource>().clip = lechucita;
        }
        else if(bird=="Loro Frentirrojo")
        {
            gameObject.GetComponent<AudioSource>().clip = loro;
        }
        else if(bird=="Tucán Pico Iris")
        {
            gameObject.GetComponent<AudioSource>().clip = tucan;
        }
    }

    private IEnumerator atencionMsj()
    {
        Debug.Log("Mensaje 0: " + textMesh.text);
        if(textMesh.text == "¡Pronto se escuchará un nuevo ave!" || textMesh.text == "¡Escucha atentamente!"){
            textMesh.text = "¡Escucha atentamente!";
        }
        else
        {
            textMesh.text = "Listen carefully!";
        }
        yield return new WaitForSeconds(.5f); // Pausa de 2 segundos
        //cambiar color rojo a textMesh
        textMesh.color = new Color(255, 0, 0, 1);
        yield return new WaitForSeconds(.5f); // Pausa de 2 segundos
        //cambiar color rojo a textMesh
        textMesh.color = new Color(0, 0, 0, 1);
        yield return new WaitForSeconds(.5f); // Pausa de 2 segundos
        //cambiar color rojo a textMesh
        textMesh.color = new Color(255, 0, 0, 1);
        yield return new WaitForSeconds(.5f); // Pausa de 2 segundos
        //cambiar color rojo a textMesh
        textMesh.color = new Color(0, 0, 0, 1);
        yield return new WaitForSeconds(.5f); // Pausa de 2 segundos
        //cambiar color rojo a textMesh
        textMesh.color = new Color(255, 0, 0, 1);
        yield return new WaitForSeconds(.5f); // Pausa de 2 segundos
        //cambiar color rojo a textMesh
        textMesh.color = new Color(0, 0, 0, 1);
        
    }

    

    private IEnumerator cambioMsj2()
    {
        // Código antes de la pausa
        if(textMesh.text == "¡Escucha atentamente!" || textMesh.text == "¡Pronto se escuchará un nuevo ave!")
        {
            textMesh.text = "¡Pronto se escuchará un nuevo ave!";
        }
        else
        {
            Debug.Log("Mensaje: " + textMesh.text);
            textMesh.text = "Soon a new bird will be heard!";
            
        }

        yield return new WaitForSeconds(.5f); // Pausa de 2 segundos
        //cambiar color rojo a textMesh
        textMesh.color = new Color(255, 0, 0, 1);
        
        yield return new WaitForSeconds(.5f); // Pausa de 2 segundos
        //cambiar color rojo a textMesh
        textMesh.color = new Color(0, 0, 0, 1);
        yield return new WaitForSeconds(.5f); // Pausa de 2 segundos
        //cambiar color rojo a textMesh
        textMesh.color = new Color(255, 0, 0, 1);
        yield return new WaitForSeconds(.5f); // Pausa de 2 segundos
        //cambiar color rojo a textMesh
        textMesh.color = new Color(0, 0, 0, 1);
        yield return new WaitForSeconds(.5f); // Pausa de 2 segundos
        //cambiar color rojo a textMesh
        textMesh.color = new Color(255, 0, 0, 1);
        yield return new WaitForSeconds(.5f); // Pausa de 2 segundos
        //cambiar color rojo a textMesh
        textMesh.color = new Color(0, 0, 0, 1);
        startGame();

    }
}
