using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    /* English Scenes */
    public void goChooseExperience(){
        SceneManager.LoadScene("experience");
    }

    public void goUserInformation(){
        SceneManager.LoadScene("information");
    }

    public void goPeninsulaExperience(){
        SceneManager.LoadScene("LoadPeninsula");
    }

    public void goSettings(){
        SceneManager.LoadScene("settings");
    }

    public void goLaguangeSettings(){
        SceneManager.LoadScene("LanguajeSettings");
    }

    public void gocredits(){
        SceneManager.LoadScene("developers");
    }

    public void goPhotobooth(){
        SceneManager.LoadScene("photobooth");
    }

    public void goRate(){
        SceneManager.LoadScene("rate");
    }
    /* END English Scenes */



    /* Spanish scenes */
    public void goChooseExperienceEspañol(){
        SceneManager.LoadScene("experienceEspañol");
    }

    public void goUserInformationEspañol(){
        SceneManager.LoadScene("informationEspañol");
    }

    public void goSettingsEspañol(){
        SceneManager.LoadScene("settingsEspañol");
    }

    public void goLaguangeSettingsEspañol(){
        SceneManager.LoadScene("LanguajeSettingsEspañol");
    }

    public void gocreditsEspañol(){
        SceneManager.LoadScene("developersEspañol");
    }

    public void goRateEspañol(){
        SceneManager.LoadScene("rateEspañol");
    }

    public void goObservatorioExperienceEspañol(){
        SceneManager.LoadScene("LoadObservatorioEspañol");
    }

    public void goPeninsulaExperienceEspaol(){
        SceneManager.LoadScene("LoadPeninsulaEspañol");
    }
    public void goPhotoboothEspañol(){
        SceneManager.LoadScene("photoboothEspañol");
    }
    /* END Spanish scenes */



    /* Península Scenes */
    public void goTororoiEspañol(){
        SceneManager.LoadScene("TororoiEspañol");
    }

    public void goVolcanEspañol(){
        SceneManager.LoadScene("Volcan");
    }

    public void goPeninsulaEspañol(){
        SceneManager.LoadScene("VAPeninsulaEspañol");
    }
    /* END Península Scenes */




    /* Observatorio Scenes */
    public void goObservatorioExperience(){
        SceneManager.LoadScene("LoadObservatorio");
    }

    public void goObservatorioExperience1(){
        SceneManager.LoadScene("LoadObservatorio1");
    }

    public void goObservatorioExperience2(){
        SceneManager.LoadScene("LoadObservatorio2");
    }

    public void goObservatorioExperience3(){
        SceneManager.LoadScene("LoadObservatorio3");
    }

    public void goObservatorioExperience4(){
        SceneManager.LoadScene("LoadObservatorio4");
    }

    public void goObservatorioExperience5(){
        SceneManager.LoadScene("LoadObservatorio5");
    }

    public void goObservatorioExperience6(){
        SceneManager.LoadScene("LoadObservatorio6");
    }

    public void goObservatorioExperience7(){
        SceneManager.LoadScene("LoadObservatorio7");
    }
    /* END Observatorio Scenes */
}
