using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class hideImage : MonoBehaviour
{
    public GameObject imgLog;

    public void hideLog(){
        imgLog.SetActive(false);
    }

    public void displayLog(){
        imgLog.SetActive(true);
    }
}
