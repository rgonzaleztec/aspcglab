using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSeasonBtn : MonoBehaviour
{


    public GameObject[] animalPins;
    // Start is called before the first frame update
    private void OnMouseUpAsButton()
    {
        this.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        changePinSeasons();
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
