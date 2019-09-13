using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePizza : MonoBehaviour
{   public float speed=0.3f;
      void Update()
    {
      
        transform.Rotate(new Vector3(0f,speed * 100 ,0f) * Time.deltaTime);
        // transform.RotateAround();
    }
}
