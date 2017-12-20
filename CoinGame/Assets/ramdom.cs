using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ramdom : MonoBehaviour {
    public int ram;
    public static int ramm1;
    public static int ramm2;
    public static int ramm3;
    public static int rammm1() {
        return ramm1;
    }
    public static int rammm2(){
        return ramm2;
    }
    public static int rammm3() {
        return ramm3;
    }
        System.Random r = new System.Random(1000);
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.S))
        {
            ram = r.Next(1000);
        }
        ramm1 = ram / 100 % 10;
        ramm2 = ram /  10 % 10;
        ramm3 = ram /   1 % 10;
	}
}
