using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialController : MonoBehaviour
{
    Material material;
    float scrollSpeed = 5;
    float timer = 0;
    float offset;
    bool upOrDown;

    void Start()
    {
        material = GetComponent<MeshRenderer>().material;
    }

    void Update()
    {
        offset = Time.time * scrollSpeed;
        TwoSidedTimer(1.5f);
    }

    /// <summary>
    /// The amazing Two Sided Timer !
    /// This timer allows you to switch from one state to the other using the bool
    /// provided to it, especially useful for moving platforms
    /// </summary>
    private void TwoSidedTimer(float maxTime)
    {
        // If timer is lower than 0 AND is going up
        if (timer <= maxTime & upOrDown)
        {
            // Activate Texture sliding up
            TextureUp();
            // and add time to the timer
            timer += Time.deltaTime;
        }
        // Else if timer is lower than 0 but is NOT going up(going down)
        else if (timer <= maxTime)
        {
            // Activate texture sliding down
            TextureDown();
            // and add time to the timer
            timer += Time.deltaTime;
        }
        // Else if (can be just else but for greater accuracy I keep it) timer is higher than 2
        else if (timer >= maxTime)
        {
            // Reset timer
            timer = 0;
            // Switch from up to down and vice versa
            upOrDown = !upOrDown; 
        }
    }

    void TextureUp()
    {
        material.SetTextureOffset("_MainTex", new Vector2(-offset, -offset));
        Debug.Log("UP");
    }
    void TextureDown()
    {
        material.SetTextureOffset("_MainTex", new Vector2(offset, offset));
        Debug.Log("DOWN");
    }
}
