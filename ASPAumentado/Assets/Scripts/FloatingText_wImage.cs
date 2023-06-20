using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.UI;

public class FloatingText_wImage : MonoBehaviour
{

    public AudioSource animalSound;
    public TextMeshPro animalName;
    public Image animalImage;

    private Animal drySeasonAnimal;
    private Animal rainySeasonAnimal;
    private bool isDrySeason = false;


    // Start is called before the first frame update
    public void setAnimal(Animal animal)
    {
        if(animal.season == "Seca")
        {
            this.drySeasonAnimal = animal;
            setAssets(this.drySeasonAnimal);
        }
        else
        {
            this.rainySeasonAnimal = animal;
        }
    }

    private void setAssets(Animal animal)
    {
        
        this.animalSound.clip = LocalizationSettings.AssetDatabase.GetLocalizedAsset<AudioClip>(animal.AudioTable, animal.audioKey);

        this.animalName.text = LocalizationSettings.StringDatabase.GetLocalizedString(animal.TextTable, animal.nameKey);

        this.animalImage.sprite = animal.image;

    }


    public void changeSeasonAnimal()
    {
        if (this.isDrySeason)
        {
            setAssets(this.drySeasonAnimal);
            this.isDrySeason = false;
        }
        else
        {
            setAssets(this.rainySeasonAnimal);
            this.isDrySeason = true;
        }
       
    }


}
