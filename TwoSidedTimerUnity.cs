using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoSidedTimerUnity : MonoBehaviour
{
    float timer = 0;
    bool upOrDown;

    void Update()
    {
        TwoSidedTimer(1.5f);
    }

    /// <summary>
    /// Two Sided Timer in Unity
    /// This timer allows you to switch from one state to the other using the bool
    /// provided to it, especially useful for moving platforms
    /// </summary>
    private void TwoSidedTimer(float maxTime)
    {
        // If timer is lower than 0 AND is going up
        if (timer <= maxTime & upOrDown)
        {
            // Implement code here

            // and add time to the timer
            timer += Time.deltaTime;
        }
        // Else if timer is lower than 0 but is NOT going up(going down)
        else if (timer <= maxTime)
        {
            // and add time to the timer
            timer += Time.deltaTime;
        }
        // Else if (can be just else but for greater accuracy I keep it) timer is higher than 2
        else if (timer >= maxTime)
        {
            // Reset timer
            timer = 0;
            // Switch boolean value to change direction/state
            upOrDown = !upOrDown;
        }
    }
}
