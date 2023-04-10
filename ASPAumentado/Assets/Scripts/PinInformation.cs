using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEditor;
//using Unity.VisualScripting;
using UnityEngine;

public class PinInformation : MonoBehaviour
{

    //Colores para el pin 
    //Rojo= Volcanes
    //Azul= Lagos y Rios
    //Verde = Montanas y cerros 
    //Amarillo = Localidades

    enum Tipo {Volcan, RioLago, Cerro, Localidad};
    [SerializeField] Tipo Pin_Type;

    public float Offset = 0.030f;
    public GameObject _floatingTextPrefab;
    public GameObject _Pointer;
    public string Text;
    
    private Color redColor    = new Color(1f, 0f, 0f);
    private Color blueColor   = new Color(0f, 0f, 1f);
    private Color greenColor  = new Color(0f, 1f, 0f);
    private Color yellowColor = new Color(1f, 1f, 0f);
  

    // Start is called before the first frame update
    void Start()
    {

        showFloatingText(Text);
        changePinColor(this.Pin_Type);

    }

    private void showFloatingText(string text)
    {
        var offset = this.transform.position + (this.transform.up * Offset); ; //+ (this.transform.right) + (this.transform.up * 0.0030f);
        var floatingText = Instantiate(_floatingTextPrefab, offset, Quaternion.identity, this.transform);
        floatingText.GetComponent<TextMeshPro>().text = text;

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
        }

    }

    private void changeColor( GameObject pObject, Color color)
    {
        Debug.Log("<color=red>GameObject:</color> " + pObject.name);
        Debug.Log("<color=red>Color:</color> " + color.ToString());
        pObject.GetComponent<Renderer>().material.SetColor("_Color", color);


    }

    // Update is called once per frame
    void Update()
    {

    }
}
