using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = .3f;
    public ONclickStopMenu m,b,c,d;

    void Update(){
        print("mcheck in manager : "+m.check);
        if(m.check==false || b.check==false ||c.check==false || d.check==false){
            speed=0;
        }
        else if( m.check == true ||b.check == true || c.check == true || d.check == true)
        {
            speed =0.3f;
        }
 
    }
}