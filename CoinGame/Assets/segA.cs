using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class segA : MonoBehaviour {
    public static int seg1 = 0;
    public static int segg() {
        return seg1;
    }

	// Use this for initialization
	void Start () {
        seg1 = 0;
    }
	
	// Update is called once per frame
	void Update () {
        seg1 = Mseg.numm();
        Color w = Color.black;
        Color b = Color.green;
        if (seg1 == 0) {
            gameObject.GetComponent<Renderer>().material.color = b; 
        }
        if (seg1 == 1)
        {
            gameObject.GetComponent<Renderer>().material.color = w;
        }
        if (seg1 == 2)
        {
            gameObject.GetComponent<Renderer>().material.color = b;
        }
        if (seg1 == 3)
        {
            gameObject.GetComponent<Renderer>().material.color = b;
        }
        if (seg1 == 4)
        {
            gameObject.GetComponent<Renderer>().material.color = w;
        }
        if (seg1 == 5)
        {
            gameObject.GetComponent<Renderer>().material.color = b;
        }
        if (seg1 == 6)
        {
            gameObject.GetComponent<Renderer>().material.color = b;
        }
        if (seg1 == 7)
        {
            gameObject.GetComponent<Renderer>().material.color = b;
        }
        if (seg1 == 8)
        {
            gameObject.GetComponent<Renderer>().material.color = b;
        }
        if (seg1 == 9)
        {
            gameObject.GetComponent<Renderer>().material.color = b;
        }

    }
}
