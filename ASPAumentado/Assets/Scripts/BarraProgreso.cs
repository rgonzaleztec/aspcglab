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
            /* 2n = Observatorio scena */
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


            /* 5 = Península ingles*/
            /* 5n = Península Escena*/
            if (numEscena == 3){
                SceneManager.LoadScene("mapPeninsula");
            }if (numEscena == 31) {                                   
                SceneManager.LoadScene("PNAgua1");
            }if (numEscena == 32) {                                   
                SceneManager.LoadScene("PNAgua2");
            }if (numEscena == 33) {                                   
                SceneManager.LoadScene("PNAgua3");
            }if (numEscena == 34) {                                   
                SceneManager.LoadScene("PNAgua4");
            }if (numEscena == 35) {                                   
                SceneManager.LoadScene("PNAgua5");
            }if (numEscena == 36) {                                   
                SceneManager.LoadScene("PNAgua6");
            }if (numEscena == 37) {                                   
                SceneManager.LoadScene("PNAgua7");
            }

            /* 4 = Refugio Nacional de Vida Silvestre Cano Negrp*/
            /* 4n = RFVSCN scena */
            if (numEscena == 4){
                SceneManager.LoadScene("map_RCanoNegro");
            }if (numEscena == 41){
                SceneManager.LoadScene("RCanoNegro1");
            }if (numEscena == 42){
                SceneManager.LoadScene("RCanoNegro2");
            }if (numEscena == 43){
                SceneManager.LoadScene("RCanoNegro3");
            }if (numEscena == 44){
                SceneManager.LoadScene("RCanoNegro4");
            }if (numEscena == 45){
                SceneManager.LoadScene("RCanoNegro5");
            }if (numEscena == 46){
                SceneManager.LoadScene("RCanoNegro6");
            }if (numEscena == 47){
                SceneManager.LoadScene("RCanoNegro7");
            }


            /* 5 = Península ingles*/
            /* 5n = Península Escena*/
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
