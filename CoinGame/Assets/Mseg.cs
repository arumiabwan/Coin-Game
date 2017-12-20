using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mseg : MonoBehaviour {
    public int cou=0;
    public int Num = 0;
    public int check;
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
        if (check == 0)
        {
            num = ramdom.rammm1();
        }
        else if (check == 1)
        {
            num = ramdom.rammm2();
        } else if(check == 2)
        {
            num = ramdom.ramm3;
        }
        if (Input.GetKey(KeyCode.F1))
        {
            num = 1;
        }
        Num = segnum.seggN();
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

        if (cou == 20)
        {
            //num--;
            cou = 0;
        }
            if(num < 0)
        {
            //num = 9;
        }
	}
}
