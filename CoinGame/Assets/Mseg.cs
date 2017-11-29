using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mseg : MonoBehaviour {
    public static int num=0;
    public static int numm()
    {
        return num;
    }
    // Use this for initialization
    void Start () {
        num = 0;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.A))
        {
            num++;
        }
            if(num > 9)
        {
            num = 0;
        }
	}
}
