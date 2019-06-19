using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    int postionToGO;
    public Path p;

    void OnMouseDown()
    {
        StartCoroutine("Movee");
    }
    IEnumerator Movee()
    {
        postionToGO = 10;
        for (int i = 0; i < postionToGO; i++)
        {

            // postionToGO =(postionToGO+1)%10;
            transform.position = p.array[i].transform.position;
            yield return new WaitForSeconds(2f);

        }
    }
}
