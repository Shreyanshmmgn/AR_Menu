using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject  scene,scene1;
    void OnMouseDown()
    {
        if (transform.tag == "Menu")
        {
            scene.SetActive(true);
            scene1.SetActive(false);
        }
        else if (transform.tag == "Card")
        {   scene.SetActive(false);
            scene1.SetActive(true);

        }
    }

}
