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
    public GameObject _floatingTextPrefabwImage;
    public Animal[] animals;

    private GameObject _floatingTextInstance;

    private Color rodColor = new Color(0.96f, 0f, 0.43f);
    private Color pointerColor = new Color(0.65f, 0f, 0.32f);



    // Start is called before the first frame update
    void Start()
    {

        showFloatingText();
        changeColor(this._Rod, rodColor);
        this._Pointer.GetComponent<ChangePointerColor>().changecolor(pointerColor);

        if (!this._Show_Rod)
        {
            hideObject(_Rod);
        }
    }

    private void showFloatingText()
    {
        var offset = this._Pointer.transform.position + (this._Pointer.transform.up * 0.014f); ; //+ (this.transform.right) + (this.transform.up * 0.0030f);
        this._floatingTextInstance = Instantiate(_floatingTextPrefabwImage, offset, Quaternion.identity, this.transform);

        this._floatingTextInstance.GetComponent<FloatingText_wImage>().setAnimal(animals[0]);
        this._floatingTextInstance.GetComponent<FloatingText_wImage>().setAnimal(animals[1]);
    }

    public void changeSeason()
    {
        this._floatingTextInstance.GetComponent<FloatingText_wImage>().changeSeasonAnimal();
    }


    private void changeColor(GameObject pObject, Color color)
    {
        pObject.GetComponent<Renderer>().material.SetColor("_Color", color);
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
