using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    float xValue = 0;
    float yValue = 0.01f;
    float zValue = 0;

    // Start is called before the first frame update
    void Start()
    {
        //this means add to the current postition this numbers
        //transform.Translate(1,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(xValue,yValue,zValue);
    }
}
