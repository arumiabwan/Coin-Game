using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*機能　po>0で回転し続ける
        sを押すと止まる
        dを押すと一定時間で止まるようにできる
        ランダムな数字を取得できる（ほかの関数でも
        public static int segg() {
        return seg1;
        }
        その数を表示できる
        適当な数/10で三桁そろう（ランダムじゃないので適当にやると連続して出てきたり、全く出てこないよ
        */

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
    public int time = 20;
    public static int po = 20000;
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
        time = Autoseg.time;
        Pp++;
        if (/*Input.GetKey(KeyCode.D)*/Autoseg.st == 1 && (po == 0 || po > time))
        {
            po = time;
            Autoseg.st = 0;
            Autoseg.In--;
        }
        if(Pp > 50)
        {
            Pp = 0;
        }

        if (po > 0)
        {

            if (Input.GetKey(KeyCode.S))
            { }else
            {
            //ここを消せば永遠に消える（というかpo>0で回り続ける
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
            if(po == 0)
            Autoseg.Hit = 1;
        }
        else
        {
            Hantei = Hazure;
            Autoseg.Hit = 0;
        }
            RAM = ramm1*100+ramm2*10+ramm3;
        Autoseg.Out = RAM;
        
            num1 = ramm1;
            num2 = ramm2;
            num3 = ramm3;
        }
    }

