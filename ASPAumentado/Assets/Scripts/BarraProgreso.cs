using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class BarraProgreso : MonoBehaviour
{
    Slider barra;
    private int cont = 0;
    public int numEscena;

    private void Start()
    {
        cargar();
    }

    void Awake()
    {
        barra = GetComponent<Slider>();
    }

    void changeBarValue(float valor_act, float valor_max)
    {
        float porcentaje;
        porcentaje = valor_act / valor_max;
        barra.value = porcentaje;
    }

    void cargar()
    {
        cont++;
        changeBarValue(cont,1000);
        if (cont <= 1000)
        {
            if (cont > 800 && cont < 850){
                Invoke("cargar",0.04f);
            }
            else{
                Invoke("cargar",0.001f);
            }
        }
        else
        {

            /* 1 = Primera scena, barra de carga del menu*/
            if (numEscena == 1){
                SceneManager.LoadScene("Languaje");
            }

            /* 2 = Observatorio Ingles*/
            /* 2n = Observatorio scena n en ingles*/
            if (numEscena == 2){
                SceneManager.LoadScene("map");
            }if (numEscena == 21){
                SceneManager.LoadScene("VAObservatorio1");
            }if (numEscena == 22){
                SceneManager.LoadScene("VAObservatorio2");
            }if (numEscena == 23){
                SceneManager.LoadScene("VAObservatorio3");
            }if (numEscena == 24){
                SceneManager.LoadScene("VAObservatorio4");
            }if (numEscena == 25){
                SceneManager.LoadScene("VAObservatorio5");
            }if (numEscena == 26){
                SceneManager.LoadScene("VAObservatorio6");
            }if (numEscena == 27){
                SceneManager.LoadScene("VAObservatorio7");
            }

            /* 4 = Observatorio Ingles*/
            /* 4n = Observatorio scena n en español*/
            if (numEscena == 4){
                SceneManager.LoadScene("mapEspañol");
            }if (numEscena == 41){
                SceneManager.LoadScene("VAObservatorio1Español");
            }if (numEscena == 42){
                SceneManager.LoadScene("VAObservatorio2Español");
            }if (numEscena == 43){
                SceneManager.LoadScene("VAObservatorio3Español");
            }if (numEscena == 44){
                SceneManager.LoadScene("VAObservatorio4Español");
            }if (numEscena == 45){
                SceneManager.LoadScene("VAObservatorio5Español");
            }if (numEscena == 46){
                SceneManager.LoadScene("VAObservatorio6Español");
            }if (numEscena == 47){
                SceneManager.LoadScene("VAObservatorio7Español");
            }

            /* 3 = Península Español*/
            /* 3n = Península scena n en español*/
            if (numEscena == 3){                                
                SceneManager.LoadScene("mapPeninsulaEspañol");
            }if (numEscena == 31) {                                   //Casetilla
                SceneManager.LoadScene("VAPeninsulaEspañol1");
            }if (numEscena == 32) {                                   //Mirador Turismo Responsable
                SceneManager.LoadScene("VAPeninsulaEspañol2");
            }if (numEscena == 33) {                                   //Tororoi
                SceneManager.LoadScene("VAPeninsulaEspañol3");
            }if (numEscena == 34) {                                   //Momotorufo
                SceneManager.LoadScene("VAPeninsulaEspañol4");
            }if (numEscena == 35) {                                   //Bosque Sano
                SceneManager.LoadScene("VAPeninsulaEspañol5");
            }if (numEscena == 36) {                                   //Torre
                SceneManager.LoadScene("VAPeninsulaEspañol6");
            }if (numEscena == 37) {                                   //Mirador  Lago - Volcan
                SceneManager.LoadScene("VAPeninsulaEspañol7");
            }


            /* 5 = Península ingles*/
            /* 5n = Península scena n en ingles*/
            if (numEscena == 5){
                SceneManager.LoadScene("mapPeninsula");
            }if (numEscena == 51) {                                   //Casetilla
                SceneManager.LoadScene("VAPeninsula1");
            }if (numEscena == 52) {                                   //Mirador Turismo Responsable
                SceneManager.LoadScene("VAPeninsula2");
            }if (numEscena == 53) {                                   //Tororoi
                SceneManager.LoadScene("VAPeninsula3");
            }if (numEscena == 54) {                                   //Momotorufo
                SceneManager.LoadScene("VAPeninsula4");
            }if (numEscena == 55) {                                   //Bosque Sano
                SceneManager.LoadScene("VAPeninsula5");
            }if (numEscena == 56) {                                   //Torre
                SceneManager.LoadScene("VAPeninsula6");
            }if (numEscena == 57) {                                   //Mirador  Lago - Volcan
                SceneManager.LoadScene("VAPeninsula7");
            }
        }

    }

}
