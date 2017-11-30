using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mseg : MonoBehaviour {
    public int cou=0;
    public int Num = 0;
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
       // Num = segnum.seggN();
        if (Num == 0)
        {
            if (Input.GetKey(KeyCode.A))
            {
                cou += 1;
            }
        } else if(Num == 1)
        {
            if (Input.GetKey(KeyCode.S))
            {
                cou += 1;
            }
        }else if (Num == 2)
        {
            if (Input.GetKey(KeyCode.D))
            {
                cou += 1;
            }
        }

        if (cou == 5)
        {
            num--;
            cou = 0;
        }
            if(num < 0)
        {
            num = 9;
        }
	}
}
