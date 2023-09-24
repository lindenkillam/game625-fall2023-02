/*
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class SoundManager : MonoBehaviour, Observer
{
    public AudioSource coalAudio;
    public AudioSource cherryAudio;

    // OnNotify is called when Achievement System receives a notification from an object
    public void OnNotify(object obj, NotificationType notificationType)
    {
        if (notificationType == NotificationType.CoalCollected)
        {
            Debug.Log("Coal sound played.");
            audioSource.Play();
        }

        if (notificationType == NotificationType.CherryCollected)
        {
            Debug.Log("Cherry sound played.");
            audioSource.Play();
        }
    }

    void Start()
    {
        // add Achievement System object as observer to all observable objects
        foreach (Observable subject in FindObjectsOfType<Observable>())
        {
            subject.AddObserver(this);
        }
    }
}
*/