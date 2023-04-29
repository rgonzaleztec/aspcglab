using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba : MonoBehaviour
{
    public GameObject cubo;
    public GameObject esfera;
    public bool activarCubo = false;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(cada5Segundos());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator cada5Segundos()
    {
            yield return new WaitForSeconds(5);
            if(activarCubo)
            {
                esfera.SetActive(false);
                cubo.SetActive(true);
                activarCubo = false;

            }
            else
            {
                cubo.SetActive(false);
                esfera.SetActive(true);
                activarCubo = true;
            }
            StartCoroutine(cada5Segundos());
    }
}
