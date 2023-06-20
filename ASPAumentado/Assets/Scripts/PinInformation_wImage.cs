using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class PinInformation_wImage : MonoBehaviour
{
    //Colores para el pin 
    //Rojo= Volcanes
    //Azul= Lagos y Rios
    //Verde = Montanas y cerros 
    //Amarillo = Localidades



    public GameObject _Pointer;
    public GameObject _Rod;
    public bool _Show_Rod = true;
    public GameObject _floatingTextPrefab;


  

  

    // Start is called before the first frame update
    void Start()
    {

        showFloatingText();

        if (!this._Show_Rod)
        {
            hideObject(_Rod);
        }
    }

    private void showFloatingText()
    {
        var offset = this._Pointer.transform.position + (this._Pointer.transform.up * 0.014f); ; //+ (this.transform.right) + (this.transform.up * 0.0030f);
        var floatingText = Instantiate(_floatingTextPrefab, offset, Quaternion.identity, this.transform);
        floatingText.GetComponent<TextMeshPro>().text = loadString();

    }



    private void hideObject(GameObject pObject)
    {
        pObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
