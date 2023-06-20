using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.UIElements;

public class ChangeSeasonBtn : MonoBehaviour
{


    public GameObject[] animalPins;
    public GameObject button;
    public TextMeshProUGUI informationLabelText;
    
    private bool isDrySeason = false;

    private void Start()
    {
        changeInformationText();

    }

    private void OnMouseDown()
    {

        Vector3 position = this.GetComponent<Transform>().position;

        this.button.GetComponent<Transform>().position = new Vector3(position.x, position.y - 0.01f,position.z);

    }
    // Start is called before the first frame update
    private void OnMouseUpAsButton()
    {
        this.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        changePinSeasons();

        Vector3 position = this.GetComponent<Transform>().position;
        this.button.GetComponent<Transform>().position = new Vector3(position.x, position.y + 0.01f, position.z);
        changeInformationText();
    }

    private void changeInformationText()
    {

        if (this.isDrySeason)
        {
            string info = LocalizationSettings.StringDatabase.GetLocalizedString("RN_CANONEGRO_TEXT", "RCN1_RainySeasonInformationLabel_Text");
            this.informationLabelText.text = info;

            this.isDrySeason= false;
        }
        else
        {
            string info  = LocalizationSettings.StringDatabase.GetLocalizedString("RN_CANONEGRO_TEXT", "RCN1_DrySeasonInformationLabel_Text");
            this.informationLabelText.text = info;
            this.isDrySeason = true;
        }

    }
   



    private void changePinSeasons()
    {


        foreach(GameObject item in animalPins)
        {
            Debug.Log(item.name);
            item.GetComponent<PinInformation_wImage>().changeSeason();

        }
    }
}
