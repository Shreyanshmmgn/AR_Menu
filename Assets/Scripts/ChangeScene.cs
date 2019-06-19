using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    public GameObject Scene1, Scene2;

    public void OnMouse()
    {
       
      Scene1.SetActive(false);
      Scene2.SetActive(true);

    }
}
