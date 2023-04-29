using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//scene management
using UnityEngine.SceneManagement;
//TMPro
using TMPro;

public class CameraTrigger : MonoBehaviour
{
    //var for a material
    public Material material;

    public Material pasto1_material;
    //TextMeshPro 3Dpublic TextMeshPro hambreMono;
    public TextMeshPro hambreMono;
    public GameObject noAlimentarAnimales;
    public GameObject noPisarPasto;
    public TextMeshPro cortarFlor;
    public GameObject noCortarFlor;
    public Transform player;
    private bool entroPasto = false;

    //TextMeshPro UI
    public TextMeshProUGUI idioma;
    public GameObject msj1;
    public GameObject msj2;
    private GameObject[] pastos;
    //audio clip
    public AudioClip audioClip;
    // Start is called before the first frame update
    void Start()
    {
        noAlimentarAnimales.gameObject.SetActive(false);
        noCortarFlor.gameObject.SetActive(false);
        noPisarPasto.gameObject.SetActive(false);
        // GameObject cubo2 = msj2.transform.GetChild(0).gameObject;
        // //set current rotation like default rotation
        // cubo2.transform.localRotation = Quaternion.identity;
        // GameObject txt2 = msj2.transform.GetChild(0).gameObject;
        // //set current rotation like default rotation
        // txt2.transform.localRotation = Quaternion.identity;

        // cortarFlor.gameObject.transform.localRotation = Quaternion.identity;
        // hambreMono.gameObject.transform.localRotation = Quaternion.identity;

        // GameObject cubo1 = msj1.transform.GetChild(0).gameObject;
        // //set current rotation like default rotation
        // cubo1.transform.localRotation = Quaternion.identity;
        // GameObject txt1 = msj1.transform.GetChild(0).gameObject;
        // //set current rotation like default rotation
        // txt1.transform.localRotation = Quaternion.identity;

        //lista de objetos con tag "pasto"
        pastos = GameObject.FindGameObjectsWithTag("pasto");
        pasto1_material = pastos[0].GetComponent<Renderer>().material;
    }

    public void loadScene(){
        string scene = idioma.text;
        if(scene == "English"){
            SceneManager.LoadScene("Punto_2_EN");
        }else if(scene == "Spanish"){
            SceneManager.LoadScene("Punto_2_ES");
        }
    }

    // Update is called once per frame
    void Update()
    {
        msj1.GetComponent<Transform>().LookAt(player);

        msj2.GetComponent<Transform>().LookAt(player);

        noAlimentarAnimales.GetComponent<Transform>().LookAt(player);

        noPisarPasto.GetComponent<Transform>().LookAt(player);

        noCortarFlor.GetComponent<Transform>().LookAt(player);

        // //get first child of the object msj2 and add 180 to Z rotation
        // GameObject cubo1 = msj2.transform.GetChild(1).gameObject;
        // //set current rotation like default rotation
        // cubo1.transform.localRotation = Quaternion.identity;

        // GameObject txt1 = msj2.transform.GetChild(0).gameObject;
        // //set 180 local rotation to y
        // txt1.transform.localRotation = Quaternion.Euler(0, 180, 0);

        // GameObject txt2 = msj1.transform.GetChild(1).gameObject;
        // //set 180 local rotation to y
        // txt2.transform.localRotation = Quaternion.Euler(0, -180, 0);

        // GameObject cubo2 = msj1.transform.GetChild(0).gameObject;
        // //set current rotation like default rotation
        // cubo2.transform.localRotation = Quaternion.identity;

        // GameObject animal = noAlimentarAnimales.transform.gameObject;
        // //set current rotation like default rotation
        // animal.transform.localRotation = Quaternion.identity;

        // GameObject flor = noCortarFlor.transform.gameObject;
        // //set current rotation like default rotation

        // flor.transform.localRotation = Quaternion.identity;
 
        
    }

    //on trigger enter
    private void OnTriggerEnter(Collider other)
    {

        //if the player enters the trigger
        if (other.gameObject.tag == "pasto" && entroPasto == false)
        {
            entroPasto = true;
            //change the material of the objects in pastos array
            foreach (GameObject pasto in pastos)
            {
                pasto.GetComponent<Renderer>().material = material;
            }
            StartCoroutine(WaitGround());

           
        }else if(other.gameObject.tag == "marketMono")
        {  
            //play the audio clip
            //AudioSource.PlayClipAtPoint(audioClip, transform.position);
            Debug.Log("Has entrado al market");
            //disable the MeshRenderer
            msj1.gameObject.SetActive(false);
            Debug.Log("Msj1 desactivado");
            noAlimentarAnimales.gameObject.SetActive(true);
            StartCoroutine(WaitAndPrint(msj1, noAlimentarAnimales));
           
        }else if(other.gameObject.tag == "marketPlanta")
        {  
            Debug.Log("Has entrado al market");
            //disable the MeshRenderer
            msj2.gameObject.SetActive(false);
            noCortarFlor.gameObject.SetActive(true);
            StartCoroutine(WaitAndPrint(msj2, noCortarFlor));
           
        }
    }

    public void animalButton(){
        //AudioSource.PlayClipAtPoint(audioClip, transform.position);
        Debug.Log("Has entrado al market");
        //disable the MeshRenderer
        msj1.gameObject.SetActive(false);
        Debug.Log("Msj1 desactivado");
        noAlimentarAnimales.gameObject.SetActive(true);
        StartCoroutine(WaitAndPrint(msj1, noAlimentarAnimales));
    }

    public void faunaButton(){
        Debug.Log("Has entrado al market");
        //disable the MeshRenderer
        msj2.gameObject.SetActive(false);
        noCortarFlor.gameObject.SetActive(true);
        StartCoroutine(WaitAndPrint(msj2, noCortarFlor));
    }

    IEnumerator WaitGround()
    {
        noPisarPasto.gameObject.SetActive(true);
        yield return new WaitForSeconds(15f);
        
        foreach (GameObject pasto in pastos)
        {
            pasto.GetComponent<Renderer>().material = pasto1_material;
        }
        noPisarPasto.gameObject.SetActive(false);
        entroPasto = false;

    }

    IEnumerator WaitAndPrint(GameObject txt1, GameObject txt2)
    {
        yield return new WaitForSeconds(15f);
        txt2.gameObject.SetActive(false);
        txt1.gameObject.SetActive(true);
    }
}
