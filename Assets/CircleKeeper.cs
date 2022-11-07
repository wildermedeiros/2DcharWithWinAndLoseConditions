using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleKeeper : MonoBehaviour
{
    [SerializeField] CircleSpawner circleSpawner = null;
    [SerializeField] bool hasWasted = false;
    [SerializeField] bool hasWinned = false;

    void Update()
    {
        if (hasWinned) { return; }
        if (transform.childCount <= 0)
        {
            print("Vitoria");
            circleSpawner.CancelInvoke();
            hasWinned = true;

            // call next level
        }

        if (hasWasted) { return; }
        if(transform.childCount >= 20)
        {
            print("Wasted");
            circleSpawner.CancelInvoke();
            hasWasted = true;
        
            // call reset level
        }
    }

    public int GetCircleCount()
    {
        return transform.childCount;
    }
}
