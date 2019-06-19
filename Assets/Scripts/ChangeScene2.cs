using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene2 : MonoBehaviour
{
    // Start is called before the first frame update
  public GameObject Scene1,Scene2,Scene3,Scene4,Scene5;
  public int Tg;

  public void OnMouse(int A)
  {    Tg=A;
       if (A == 1)
        { 
            Scene1.SetActive(false);
            Scene2.SetActive(true);
           
        }
        else if (A == 2)
        {  
            Scene1.SetActive(false);
            Scene3.SetActive(true);
            
        }
        else if (A == 3)
        {   
            Scene1.SetActive(false);
            Scene4.SetActive(true);
            
        }
        else if (A == 4)
        {  
            Scene1.SetActive(false);
            Scene5.SetActive(true);
           
        }
        
  }
}
