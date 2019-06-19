using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{ public GameObject Scene1;

  public void OnMouse()
  {    
       if ( Scene1.activeSelf==true)
        { 
           
            Scene1.SetActive(false);
           
        }
     
        
  }
}
