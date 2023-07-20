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


    // Esto hay que borrarlo *************************************
    public void goObservatorioExperience1PD()
    {
        SceneManager.LoadScene("VAObservatorio1PD-Prueba_Plane_Detection");
    }

    public void goObservatorioExperience2PD()
    {
        SceneManager.LoadScene("VAObservatorio2PD-Prueba_Plane_Detection");
    }

    public void goObservatorioExperience7T()
    {
        SceneManager.LoadScene("VAObservatorio7_PhotoBooth_ConTarget");
    }

    public void goPeninsulaExperience7MA()                   //Turismo Responsable
    {
        SceneManager.LoadScene("VAPeninsula7_MidAirAnchor");
    }
    //*************************************




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


    //                                                                                 ****** Parque del Agua PNJCB Scenes ******

    /* Observatorio Scenes */
    public void goParqueAguaExperience()
    {
        SceneManager.LoadScene("LoadParqueAgua");
    }

    public void goParqueAguaExperience1()
    {
        SceneManager.LoadScene("LoadParqueAgua1");
    }

    public void goParqueAguaExperience2()
    {
        SceneManager.LoadScene("LoadParqueAgua2");
    }

    public void goParqueAguaExperience3()
    {
        SceneManager.LoadScene("LoadParqueAgua3");
    }

    public void goParqueAguaExperience4()
    {
        SceneManager.LoadScene("LoadParqueAgua4");
    }

    public void goParqueAguaExperience5()
    {
        SceneManager.LoadScene("LoadParqueAgua5");
    }

    public void goParqueAguaExperience6()
    {
        SceneManager.LoadScene("LoadParqueAgua6");
    }

    public void goParqueAguaExperience7()
    {
        SceneManager.LoadScene("LoadParqueAgua7");
    }
    /* END Observatorio Scenes */


    //                                                                                 ****** Cano Negro RNVSCN Scenes ******

    /* Observatorio Scenes */
    public void goCanoNegroExperience()
    {
        SceneManager.LoadScene("LoadCanoNegro");
    }

    public void goCanoNegroExperience1()
    {
        SceneManager.LoadScene("LoadCanoNegro1");
    }

    public void goCanoNegroExperience2()
    {
        SceneManager.LoadScene("LoadCanoNegro2");
    }

    public void goCanoNegroExperience3()
    {
        SceneManager.LoadScene("LoadCanoNegro3");
    }

    public void goCanoNegroExperience4()
    {
        SceneManager.LoadScene("LoadCanoNegro4");
    }

    public void goCanoNegroExperience5()
    {
        SceneManager.LoadScene("LoadCanoNegro5");
    }

    public void goCanoNegroExperience6()
    {
        SceneManager.LoadScene("LoadCanoNegro6");
    }

    public void goCanoNegroExperience7()
    {
        SceneManager.LoadScene("LoadCanoNegro7");
    }
    /* END Observatorio Scenes */


}
