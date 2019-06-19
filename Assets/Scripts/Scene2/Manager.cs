using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public Burger Bur;
    public Cofee cof;
    public Pepsi pep;
    public Pizza piz;
    void Update(){
    if(Bur.speed==0|| cof.speed==0 || pep.speed==0|| piz.speed==0){speed=0;}

}
}