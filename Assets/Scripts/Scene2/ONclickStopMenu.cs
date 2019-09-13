using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ONclickStopMenu : MonoBehaviour
{
    public GameObject scene1, lighti;
    public bool check = true;
    void OnMouseDown()
    {

        check = false;
        if (transform.tag == "1")
        {
            scene1.SetActive(true);
            lighti.SetActive(true);


        }
        else if (transform.tag == "2")
        {
            scene1.SetActive(true);
            lighti.SetActive(true);
        }
        else if (transform.tag == "3")
        {
            scene1.SetActive(true);
            lighti.SetActive(true);
        }
        else if (transform.tag == "4")
        {
            scene1.SetActive(true);
            lighti.SetActive(true);
        }
    }

}
