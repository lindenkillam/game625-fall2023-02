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
        //Debug.Log("Coal collected!");
        if (gm.timer > 0)
        {
            gm.score += 1;
            gm.coals += 1;
        }
    }

    private void CherryCollected()
    {
        //Debug.Log("Cherry collected!");
        if (gm.timer > 0)
        {
            gm.score += 3;
            gm.cherries += 1;
        }
    }

    /*
    private void UnlockSphereCollectedAchievement(string c)
    {
        Debug.Log(c);
    }
    */

}
