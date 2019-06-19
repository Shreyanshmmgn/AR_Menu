using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Manager manage;
    //    public float speed =5f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f, 0f, manage.speed * 100) * Time.deltaTime);
        // transform.RotateAround();
    }

}
