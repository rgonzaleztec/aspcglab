using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouristGuideChecker : MonoBehaviour
{
    public AudioSource audioSource;
    public Animator animator;
    public GameObject targetObject;

    private bool isAudioPlaying = false;

    private void Start()
    {
        if (targetObject != null)
        {
            audioSource = targetObject.GetComponent<AudioSource>();
            animator = GetComponent<Animator>();
        }
        else
        {
            Debug.LogError("Target object is not assigned!");
        }
    }

    private void Update()
    {
        if (audioSource != null && animator != null)
        {
            if (audioSource.isPlaying && !isAudioPlaying)
            {
                isAudioPlaying = true;
            }
            else if (!audioSource.isPlaying && isAudioPlaying)
            {
                isAudioPlaying = false;
                animator.enabled = false;
            }
        }
    }
}
