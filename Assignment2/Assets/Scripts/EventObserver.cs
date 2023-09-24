using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventObserver : MonoBehaviour//, Observer
{
    public GameManager gm;

    void Start()
    {
        CollectionNotifier.OnCoalCollected += CoalCollected;
        CollectionNotifier.OnCherryCollected += CherryCollected;
    }

    private void CoalCollected()
    {
        Debug.Log("Coal collected!");
        gm.score += 1;

    }

    private void CherryCollected()
    {
        Debug.Log("Cherry collected!");
        gm.score += 3;
    }

    /*
    private void UnlockSphereCollectedAchievement(string c)
    {
        Debug.Log(c);
    }
    */

}
