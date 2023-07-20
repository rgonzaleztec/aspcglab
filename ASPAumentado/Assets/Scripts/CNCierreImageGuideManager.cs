using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.UI;

public class CNCierreImageGuideManager : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource GuideAudioSource;
    public Image BoardImage;
    public GameObject button; 

    public Sprite DefaultImage;

    public string AudioInformationTable;
    public string AudioInformationKey;


    public Sprite[] Images;
    




    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnMouseDown()
    {

        Vector3 position = this.GetComponent<Transform>().position;

        this.button.GetComponent<Transform>().position = new Vector3(position.x, position.y - 0.01f, position.z);

    }
    // Start is called before the first frame update
    private void OnMouseUpAsButton()
    {
        this.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);

        Vector3 position = this.GetComponent<Transform>().position;
        this.button.GetComponent<Transform>().position = new Vector3(position.x, position.y + 0.01f, position.z);

        
        if (CNCierreSingleton.Instance.behaviour != null)
        {
            CNCierreSingleton.Instance.behaviour.StopAllCoroutines();
        }
        

        AudioClip infomationClip = LocalizationSettings.AssetDatabase.GetLocalizedAsset<AudioClip>(AudioInformationTable, AudioInformationKey);
        GuideAudioSource.clip = infomationClip;
        GuideAudioSource.Play();

        CNCierreSingleton.Instance.behaviour = this;

        StartCoroutine("PlayPresentation");
    }


    IEnumerator PlayPresentation()
    {

        while (GuideAudioSource.isPlaying)
        {
            foreach (var image in Images)
            {
                BoardImage.sprite = image;
                yield return new WaitForSeconds(2f);
            }
        }

        BoardImage.sprite = DefaultImage;

    }
}
