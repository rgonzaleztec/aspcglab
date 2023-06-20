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
        this._floatingTextInstance = Instantiate(_floatingTextPrefabwImage, offset, Quaternion.identity, this.transform);

        this._floatingTextInstance.GetComponent<FloatingText_wImage>().setAnimal(animals[0]);
        this._floatingTextInstance.GetComponent<FloatingText_wImage>().setAnimal(animals[1]);
    }

    public void changeSeason()
    {
        this._floatingTextInstance.GetComponent<FloatingText_wImage>().changeSeasonAnimal();
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
