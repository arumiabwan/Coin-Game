using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class segnum : MonoBehaviour {
    public int segn = 0;
    public static int segN = 0;
    public static int seggN()
    {
        return segN;
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        segN = segn;
	}
}
