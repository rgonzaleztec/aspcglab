using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelLoader : MonoBehaviour
{
    
    public Animator transition;
    public float transitionTime = 1f;

    public void startAnimation(){
        StartCoroutine(LoadLevel());
    }

    IEnumerator LoadLevel()
    {
        //Play animation
        transition.SetTrigger("start");

        //wait
        yield return new WaitForSeconds(transitionTime);
    }
}
