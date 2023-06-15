using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEditor;
//using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Localization.Settings;



public class PinInformation : MonoBehaviour
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
    public String localizedDatabase = "PNVA_PENINSULA_TEXT";


    enum Tipo {Volcan, RioLago, Cerro, Localidad, EtiquetaInformacion};
    [SerializeField] Tipo Pin_Type;
    public string Text;
    public string LocalizedKey;
    private float TextOffset = 0.014f;


    private Color redColor    = new Color(1f, 0f, 0f);
    private Color blueColor   = new Color(0f, 0f, 1f);
    private Color greenColor  = new Color(0f, 1f, 0f);
    private Color yellowColor = new Color(1f, 1f, 0f);
  
    private string loadString()
    {
        Debug.Log("Load String");

        var location = LocalizationSettings.StringDatabase.GetLocalizedString(localizedDatabase, this.LocalizedKey);

        if (location != null)
        {
            Debug.Log(location);
            return location;
        }

        else {
            Debug.Log(location);
            return this.Text;
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {

        showFloatingText();
        changePinColor(this.Pin_Type);

        if (!this._Show_Rod)
        {
            hideObject(_Rod);
        }
    }

    private void showFloatingText()
    {
        var offset = this._Pointer.transform.position + (this._Pointer.transform.up * TextOffset); ; //+ (this.transform.right) + (this.transform.up * 0.0030f);
        var floatingText = Instantiate(_floatingTextPrefab, offset, Quaternion.identity, this.transform);
        floatingText.GetComponent<TextMeshPro>().text = loadString();

    }

    private void changePinColor(Tipo Pin_Type)
    {
        Debug.Log("<color=red>Cambiando el pin a color:</color> " + Pin_Type);

        switch (Pin_Type)
        {
            case Tipo.Volcan:
                changeColor(this._Pointer, redColor);
                break;
            case Tipo.RioLago:
                changeColor(this._Pointer, blueColor);
                break;
            case Tipo.Cerro:
                changeColor(this._Pointer, greenColor);
                break;
            case Tipo.Localidad:
                changeColor(this._Pointer, yellowColor);
                break;
            case Tipo.EtiquetaInformacion:
                changeColor(this._Pointer, greenColor);
                break;
        }
    }

    private void changeColor( GameObject pObject, Color color)
    {
        pObject.GetComponent<Renderer>().material.SetColor("_Color", color);
    }

    private void hideObject( GameObject pObject)
    {
        pObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
