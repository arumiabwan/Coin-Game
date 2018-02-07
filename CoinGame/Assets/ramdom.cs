using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ramdom : MonoBehaviour {
    public int ram;
    public static int RAM;
    public int num1,num2,num3;
    public static int ramm1;
    public static int ramm2;
    public static int ramm3;
    public string Hantei;
    string Atari = "あたり";
    string Hazure = "はずれ";
    int Pp,pp;
    public int po = 1000;
    int Po=0;
    public static int rammm1() {
        return ramm1;
    }
    public static int rammm2(){
        return ramm2;
    }
    public static int rammm3() {
        return ramm3;
    }
    public static int rammm()
    {
        return RAM;
    }
        System.Random r = new System.Random(1000);
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Pp++;
        if(Pp > 50)
        {
            Pp = 0;
        }

        if (po > 0)
        {

            if (Input.GetKey(KeyCode.S))
            {
            po--;
                for (int i = 0; i < 100; i++)
                {
                    ram = r.Next(1000);
                    pp = Pp;
                }
            }
        }
 
        if (pp < 10)
        {
            ramm1 = pp;
            ramm2 = pp;
            ramm3 = pp;
        }
        else
        {
            ramm1 = ram / 100 % 10;
            ramm2 = ram / 10 % 10;
            ramm3 = ram / 1 % 10;
        }
        if (ramm1 == ramm2 && ramm1 == ramm3)
        {
            Hantei = Atari;
        }
        else
        {
            Hantei = Hazure;
        }
            RAM = ramm1*100+ramm2*10+ramm3;

            num1 = ramm1;
            num2 = ramm2;
            num3 = ramm3;
        }
    }

