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
    //Carga el Mapa de Peninsula en ingles 
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

    //Carga el Mapa de Peninsula Espanol
    public void goPeninsulaExperienceEspaol(){
        SceneManager.LoadScene("LoadPeninsulaEspañol");
    }
    public void goPhotoboothEspañol(){
        SceneManager.LoadScene("photoboothEspañol");
    }
    /* END Spanish scenes */



    /* Península Scenes */
    //                                                                                 ****** Peninsula Spanish Scenes ******
    public void goPeninsulaEspañol()                              //Mapa Peninsula Espanol
    {
        SceneManager.LoadScene("LoadPeninsulaEspañol");
    }
    public void goPeninsulaExperienceEspañol1()                   //Casetilla
    {
        SceneManager.LoadScene("LoadPeninsulaEspañol1");
    }
    public void goPeninsulaExperienceEspañol2()                   //Turismo Responsable
    {
        SceneManager.LoadScene("LoadPeninsulaEspañol2");
    }
    public void goPeninsulaExperienceEspañol3()                   //Tororoi
    {
        SceneManager.LoadScene("LoadPeninsulaEspañol3");
    }
    public void goPeninsulaExperienceEspañol4()                   //Momoto
    {
        SceneManager.LoadScene("LoadPeninsulaEspañol4");
    }
    public void goPeninsulaExperienceEspañol5()                   //Bosque Sano
    {
        SceneManager.LoadScene("LoadPeninsulaEspañol5");
    }
    public void goPeninsulaExperienceEspañol6()                   //Torre
    {
        SceneManager.LoadScene("LoadPeninsulaEspañol6");
    }
    public void goPeninsulaExperienceEspañol7()                   //Volcan
    {
        SceneManager.LoadScene("LoadPeninsulaEspañol7");
    }

    //                                                                                 ****** Peninsula English Scenes ******
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
