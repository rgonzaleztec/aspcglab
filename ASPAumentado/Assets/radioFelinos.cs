using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Localization.Settings;

public class radioFelinos : MonoBehaviour
{
    //array con nombre de 4 apajaros
    private string[] birds = new string[4];
    public string bird;
    private string birdAnt = "";
    [SerializeField] private AudioClip ocelote;
    [SerializeField] private AudioClip puma;
    [SerializeField] private AudioClip leopardo;
    [SerializeField] private AudioClip jaguar;

    [SerializeField] private AudioClip audioCorrecto;
    //textMesh pro gui text
    [SerializeField] public TextMeshProUGUI textMesh;

    private string listenCarefullyText = "";
    private string soonNewSoundText = "";


    public void startGame()
    {
        listenCarefullyText = LocalizationSettings.StringDatabase.GetLocalizedString("RN_CANONEGRO_TEXT", "RCN_ListenCarefully");
        soonNewSoundText = LocalizationSettings.StringDatabase.GetLocalizedString("RN_CANONEGRO_TEXT", "RCN_NuevoSonido");


        birds[0] = "Manigordo";
        birds[1] = "Leopardo";
        birds[2] = "Puma Concolor";
        birds[3] = "Jaguar";
        Debug.Log("Start Game: " + birds.Length);

        
        bird = birds[Random.Range(0, 4)];
        Debug.Log("Start Game: " + bird);
        birdAnt = bird;
            

        if(bird=="Manigordo")
        {
            audioCorrecto = ocelote;
        }
        else if(bird=="Leopardo")
        {
            audioCorrecto = leopardo;
        }
        else if(bird=="Jaguar")
        {
            audioCorrecto = jaguar;
        }
        else if(bird=="Puma Concolor")
        {
            audioCorrecto = puma;
        }
        
        gameObject.GetComponent<AudioSource>().clip = audioCorrecto;
        gameObject.GetComponent<AudioSource>().Play();
        StartCoroutine(atencionMsj());
        
    }

    public void reSelection()
    {
        StartCoroutine(cambioMsj2());

        while(true){
            bird = birds[Random.Range(0, 4)];
            if(bird != birdAnt){
                birdAnt = bird;
                break;
            }
        }
        if(bird=="Manigordo")
        {
            audioCorrecto = ocelote;
        }
        else if(bird=="Leopardo")
        {
            audioCorrecto = leopardo;
        }
        else if(bird=="Jaguar")
        {
            audioCorrecto = jaguar;
        }
        else if(bird=="Puma Concolor")
        {
            audioCorrecto = puma;
        }
        gameObject.GetComponent<AudioSource>().clip = audioCorrecto;
        
    }


    private IEnumerator atencionMsj()
    {
        Debug.Log("Mensaje 0: " + textMesh.text);
        if(textMesh.text == soonNewSoundText || textMesh.text == listenCarefullyText){
            textMesh.text = listenCarefullyText;
        }
        else
        {
            textMesh.text = listenCarefullyText;
        }
        yield return new WaitForSeconds(.5f); // Pausa de 2 segundos
        //cambiar color rojo a textMesh
        textMesh.color = Color.yellow;
        yield return new WaitForSeconds(.5f); // Pausa de 2 segundos
        //cambiar color rojo a textMesh
        textMesh.color = Color.white;
        yield return new WaitForSeconds(.5f); // Pausa de 2 segundos
        //cambiar color rojo a textMesh
        textMesh.color = Color.yellow;
        yield return new WaitForSeconds(.5f); // Pausa de 2 segundos
        //cambiar color rojo a textMesh
        textMesh.color = Color.white;
        yield return new WaitForSeconds(.5f); // Pausa de 2 segundos
        //cambiar color rojo a textMesh
        textMesh.color = Color.yellow;
        yield return new WaitForSeconds(.5f); // Pausa de 2 segundos
        //cambiar color rojo a textMesh
        textMesh.color = Color.white;

    }

    private IEnumerator cambioMsj2()
    {
        // Código antes de la pausa
        if(textMesh.text == listenCarefullyText || textMesh.text == soonNewSoundText)
        {
            textMesh.text = soonNewSoundText;
        }
        else
        {
            Debug.Log("Mensaje: " + textMesh.text);
            textMesh.text = soonNewSoundText;
            
        }

        yield return new WaitForSeconds(.5f); // Pausa de 2 segundos
        //cambiar color rojo a textMesh
        textMesh.color = Color.yellow;
        
        yield return new WaitForSeconds(.5f); // Pausa de 2 segundos
        //cambiar color rojo a textMesh
        textMesh.color = Color.white;
        yield return new WaitForSeconds(.5f); // Pausa de 2 segundos
        //cambiar color rojo a textMesh
        textMesh.color = Color.yellow;
        yield return new WaitForSeconds(.5f); // Pausa de 2 segundos
        //cambiar color rojo a textMesh
        textMesh.color = Color.white;
        yield return new WaitForSeconds(.5f); // Pausa de 2 segundos
        //cambiar color rojo a textMesh
        textMesh.color = Color.yellow;
        yield return new WaitForSeconds(.5f); // Pausa de 2 segundos
        //cambiar color rojo a textMesh
        textMesh.color = Color.white;
        startGame();

    }
}
