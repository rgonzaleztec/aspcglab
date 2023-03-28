using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingText : MonoBehaviour
{
    //Camara para que el texto se muestre viendo a la camara 
    Camera cameraToLookAt;



    //public float DestroyTime = 3f;
    // Start is called before the first frame update
    void Start()
    {
        cameraToLookAt = Camera.main;
        //Destroy(gameObject, DestroyTime);
    }

    void LateUpdate()
    {
        //Cada frame se actualiza el transform del texto para que siempre quede viendo a la camara. 
        transform.LookAt(cameraToLookAt.transform);
        transform.rotation = Quaternion.LookRotation(cameraToLookAt.transform.forward);
    }

}
