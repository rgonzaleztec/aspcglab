using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class rate : MonoBehaviour
{
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    public GameObject star4;
    public GameObject star5;

    public GameObject panel;

    string weather = "";
    int rateValue = 0; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void oneStar(){
        emptyStars();
        star1.SetActive(true);
        rateValue = 1;
    }

    public void twoStar(){
        emptyStars();
        star1.SetActive(true);
        star2.SetActive(true);
        rateValue = 2;
    }

    public void threeStar(){
        emptyStars();
        star1.SetActive(true);
        star2.SetActive(true);
        star3.SetActive(true);
        rateValue = 3;
    }

    public void fourStar(){
        emptyStars();
        star1.SetActive(true);
        star2.SetActive(true);
        star3.SetActive(true);
        star4.SetActive(true);
        rateValue = 4;
    }

    public void fiveStar(){
        emptyStars();
        star1.SetActive(true);
        star2.SetActive(true);
        star3.SetActive(true);
        star4.SetActive(true);
        star5.SetActive(true);
        rateValue = 5;
    }

    public void emptyStars(){
        star1.SetActive(false);
        star2.SetActive(false);
        star3.SetActive(false);
        star4.SetActive(false);
        star5.SetActive(false);
    }

    //Weather
    public void sunnyWeather(){
        weather = "sunny";
    }

    public void foggyWeather(){
        weather = "foggy";
    }

    public void rainyWeather(){
        weather = "rainy";
    }

    public void sentData(){
        Console.WriteLine("Rate view data");
        Console.WriteLine("Weather: "+weather);
        Console.WriteLine("Rate: "+rateValue.ToString());
    }

    public void validation(){
        if(weather == "" || rateValue == 0){
            panel.SetActive(true);
        }else{
            sentData();
            SceneManager.LoadScene("experience");
        }
    }

    public void validationEspañol(){
        if(weather == "" || rateValue == 0){
            panel.SetActive(true);
        }else{
            sentData();
            SceneManager.LoadScene("experienceEspañol");
        }
    }

    public void okValidation(){
        panel.SetActive(false);
    }
}
