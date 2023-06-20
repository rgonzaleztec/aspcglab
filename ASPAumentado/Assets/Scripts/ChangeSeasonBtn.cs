using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ChangeSeasonBtn : MonoBehaviour
{


    public GameObject[] animalPins;
    public GameObject button;


    private void OnMouseDown()
    {

        Vector3 position = this.GetComponent<Transform>().position;

        this.button.GetComponent<Transform>().position = new Vector3(position.x, this.button.GetComponent<Transform>().position.y - 0.6f,position.z);

    }
    // Start is called before the first frame update
    private void OnMouseUpAsButton()
    {
        this.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        changePinSeasons();

        Vector3 position = this.GetComponent<Transform>().position;
        this.button.GetComponent<Transform>().position = new Vector3(position.x, this.button.GetComponent<Transform>().position.y + 0.6f, position.z);
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
