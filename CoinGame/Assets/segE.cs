using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class segE : MonoBehaviour {
    public static int seg = 0;
    public int num;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        seg = Mseg.numm();
        num = seg;
        Color w = Color.white;
        Color b = Color.red;
        if (seg == 0)
        {
            gameObject.GetComponent<Renderer>().material.color = b;
        }
        if (seg == 1)
        {
            gameObject.GetComponent<Renderer>().material.color = w;
        }
        if (seg == 2)
        {
            gameObject.GetComponent<Renderer>().material.color = b;
        }
        if (seg == 3)
        {
            gameObject.GetComponent<Renderer>().material.color = w;
        }
        if (seg == 4)
        {
            gameObject.GetComponent<Renderer>().material.color = w;
        }
        if (seg == 5)
        {
            gameObject.GetComponent<Renderer>().material.color = w;
        }
        if (seg == 6)
        {
            gameObject.GetComponent<Renderer>().material.color = b;
        }
        if (seg == 7)
        {
            gameObject.GetComponent<Renderer>().material.color = w;
        }
        if (seg == 8)
        {
            gameObject.GetComponent<Renderer>().material.color = b;
        }
        if (seg == 9)
        {
            gameObject.GetComponent<Renderer>().material.color = w;
        }
    }
}
