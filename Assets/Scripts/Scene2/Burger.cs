using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Scene1, Scene2, lighti;
   public int speed;
    public void OnMouseDown()
    {
        // Scene1.SetActive(false);
        // Scene2.SetActive(true);
        lighti.SetActive(true);
        speed =0;
    }
}
