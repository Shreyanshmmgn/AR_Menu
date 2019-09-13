using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayVideo : MonoBehaviour
{
    public GameObject VPlayer;
    public int stop;
    // Update is called once per frame
    void OnMouseDown()
    {
        // VPlayer.SetActive(true);
        Destroy(VPlayer, stop);
    }
}
