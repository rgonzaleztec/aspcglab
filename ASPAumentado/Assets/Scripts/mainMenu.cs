using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Localization.Settings;

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

    enum Languages {English, Spanish};

    private void changeAppLanguage(Languages lang)
    {

        switch(lang)
        {
            case Languages.English:
                LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[0];
                break;
            case Languages.Spanish:
                LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[1];
                break;
        }
        
    }


    public void changeLanguageToSpanish()
    {
        changeAppLanguage(Languages.Spanish);
    }

    public void changeLanguageToEnglish()
    {
        changeAppLanguage(Languages.English);
    }

    /* English Scenes */
    public void goChooseExperience(){
        SceneManager.LoadScene("experience");
    }

    //English Button Pressed
    public void goUserInformation(){
        changeLanguageToEnglish();
        SceneManager.LoadScene("information");
    }

    //Spanish Button Pressed
    public void goUserInformationEspañol()
    {
        changeLanguageToSpanish();
        SceneManager.LoadScene("information");
    }

    //Carga el Mapa de Peninsula
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
    

    //                                                                                 ****** Peninsula Scenes ******
    public void goPeninsula()                              //Mapa Peninsula Espanol
    {
        SceneManager.LoadScene("LoadPeninsula");
    }
    public void goPeninsulaExperience1()                   //Casetilla
    {
        SceneManager.LoadScene("LoadPeninsula1");
    }
    public void goPeninsulaExperience2()                   //Turismo Responsable
    {
        SceneManager.LoadScene("LoadPeninsula2");
    }
    public void goPeninsulaExperience3()                   //Tororoi
    {
        SceneManager.LoadScene("LoadPeninsula3");
    }
    public void goPeninsulaExperience4()                   //Momoto
    {
        SceneManager.LoadScene("LoadPeninsula4");
    }
    public void goPeninsulaExperience5()                   //Bosque Sano
    {
        SceneManager.LoadScene("LoadPeninsula5");
    }
    public void goPeninsulaExperience6()                   //Torre
    {
        SceneManager.LoadScene("LoadPeninsula6");
    }
    public void goPeninsulaExperience7()                   //Volcan
    {
        SceneManager.LoadScene("LoadPeninsula7");
    }


    /* END Península Scenes */


    //                                                                                 ****** Observatorio Scenes ******

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
