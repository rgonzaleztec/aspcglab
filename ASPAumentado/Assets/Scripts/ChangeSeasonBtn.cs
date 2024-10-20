using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.UI;

public class ChangeSeasonBtn : MonoBehaviour
{


    public GameObject[] animalPins;

    private bool isDrySeason = false; //True = Dry, False = Rainy  
    [SerializeField]
    private Image weatherImage;
    [SerializeField]
    private Sprite DrySeasonImage;
    [SerializeField]
    private Sprite RainySeasonImage;

    [SerializeField]
    private TextMeshProUGUI seasonLabel;

    [SerializeField]
    private TextMeshProUGUI startMonthLabel;

    [SerializeField]
    private TextMeshProUGUI finishMonthLabel;



    private void Start()
    {
        changeInformationText();

    }  

    public void changeInformationText()
    {

        if (this.isDrySeason)
        {


            changePinSeasons();
            weatherImage.sprite = DrySeasonImage;
            seasonLabel.text = LocalizationSettings.StringDatabase.GetLocalizedString("RN_CANONEGRO_TEXT", "RCN1_DrySeasonInformationLabel_Text");
            startMonthLabel.text = LocalizationSettings.StringDatabase.GetLocalizedString("RN_CANONEGRO_TEXT", "RCN1_DrySeasonStartMonth_Text");
            finishMonthLabel.text = LocalizationSettings.StringDatabase.GetLocalizedString("RN_CANONEGRO_TEXT", "RCN1_DrySeasonFinishMonth_Text");


           
            

            this.isDrySeason = false;
        }
        else
        {

            changePinSeasons();
            weatherImage.sprite = RainySeasonImage;
            seasonLabel.text = LocalizationSettings.StringDatabase.GetLocalizedString("RN_CANONEGRO_TEXT", "RCN1_RainySeasonInformationLabel_Text"); ;
            startMonthLabel.text = LocalizationSettings.StringDatabase.GetLocalizedString("RN_CANONEGRO_TEXT", "RCN1_RainySeasonStartMonth_Text");
            finishMonthLabel.text = LocalizationSettings.StringDatabase.GetLocalizedString("RN_CANONEGRO_TEXT", "RCN1_RainySeasonFinishMonth_Text");


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
