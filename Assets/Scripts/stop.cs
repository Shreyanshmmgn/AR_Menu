using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stop : MonoBehaviour
{
    public GameObject Scene1,Scene2,Scene3,Scene4;

    public void OnMouse()
    {
        if (Scene1.activeSelf == true)
        {

            Scene1.SetActive(false);

        }
        else if (Scene2.activeSelf == true)
        {
             Scene2.SetActive(false);
        }
        else if (Scene3.activeSelf == true)
        {
             Scene3.SetActive(false);
        }
        else if (Scene4.activeSelf == true)
        {
             Scene4.SetActive(false);
        }

    }
}
