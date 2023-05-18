using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeImages : MonoBehaviour
{
    float seconds;
    ArrayList listSeconds = new ArrayList();
    ArrayList materials = new ArrayList();

    public Material meterial1;
    public Material meterial2;
    public Material meterial3;
    public Material meterial4;
    public Material meterial5;
    public Material meterial6;
    public Material meterial7;
    public Material meterial8;
    public Material meterial9;
    public Material meterial10;
    public Material meterial11;
    public Material meterial12;

    public GameObject tele;

    // Start is called before the first frame update
    void Start()
    {
        listSeconds.Add(4f);
        listSeconds.Add(7.39f);
        listSeconds.Add(5.09f);
        listSeconds.Add(12.02f);
        listSeconds.Add(6.15f);
        listSeconds.Add(5.49f);
        listSeconds.Add(8.25f);
        listSeconds.Add(9.61f);
        listSeconds.Add(16.48f);
        listSeconds.Add(4.65f);
        listSeconds.Add(5.55f);
        listSeconds.Add(14.07f);
        listSeconds.Add(4f);
        materials.Add(meterial1);
        materials.Add(meterial2);
        materials.Add(meterial3);
        materials.Add(meterial4);
        materials.Add(meterial5);
        materials.Add(meterial6);
        materials.Add(meterial7);
        materials.Add(meterial8);
        materials.Add(meterial9);
        materials.Add(meterial10);
        materials.Add(meterial11);
        materials.Add(meterial12);

         StartCoroutine(nextImage());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator nextImage(){
        for(int i= 0; i< listSeconds.Count; i++){
            yield return new WaitForSeconds((float)listSeconds[i]);
            // Obtener una referencia al componente Renderer del objeto.

            Renderer renderer = tele.GetComponent<Renderer>();

            // Asignar el nuevo material al componente Renderer.
            renderer.material = (Material)materials[i];
        }
        
    }
}
