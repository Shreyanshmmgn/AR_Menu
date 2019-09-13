using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour
{
    public GameObject Scene1, Scene2,lighti;
    public ONclickStopMenu m;
    public void OnMouse()
    {
        Scene1.SetActive(false);
        Scene2.SetActive(true);
        m.check = true;
        lighti.SetActive(false);
    }
}
