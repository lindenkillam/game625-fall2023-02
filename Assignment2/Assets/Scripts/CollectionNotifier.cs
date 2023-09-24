using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CollectionNotifier : MonoBehaviour
{
    //public static event Action<CollectionNotifier> OnCubeChangedColor;
    public static event Action OnCoalCollected;
    public static event Action OnCherryCollected;

    private void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (this.CompareTag("Coal") && OnCoalCollected != null) // check if anyone subscribed to this event
        {
            OnCoalCollected(); // run the event on all subscribers
        }
        else if (this.CompareTag("Cherry") && OnCherryCollected != null)
        {
            OnCherryCollected();
        }

        Destroy(this.gameObject);
    }

}