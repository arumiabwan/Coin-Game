using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*ここをいじればほかの見なくてもいじれるようにしたいという気持ちの元作った
 * スロットが回り続ける時間を変えられる（時間を測っているわけじゃないのでPCの性能に依存する
 * ここのInの値を10にするとユーザーにスロットを回す権利が10回与えられる
 * Fキーを押すとスロットが回り、止まった時の値をOutに出力する
 * さらにその値がぞろ目だった場合Hitの値を1にする
 * 
  */

public class Autoseg : MonoBehaviour {

    
    public static int time;
    public static int In=10;
    public static int Out;
    public static int Hit = 0;
 //   public int role = 1;

    //タイムだけ、いじるのはUnity上でできるよ＿ほかは目にみえるだけ
    public int TIME,NOKORI,ATAI,HANTEI;
    public static int Time()
    {
        return time;
    }
    public static int st=0;

    public static int St()
    {
        return st;
    }
    public static int dt=0;

    public static int Dt()
    {
        return dt;
    }

    public static int hi = 0;

    public static int Hi()
    {
        return hi;
    }
    // Use this for initialization
    void Start () {
        time = TIME;
		
	}
	
	// Update is called once per frame
	void Update () {
        NOKORI = In;
        ATAI = Out;
        HANTEI = Hit;
        
        if(Input.GetKey(KeyCode.G))
        {
            In++;
        }
		if(Input.GetKeyUp(KeyCode.F) && dt == 0 && In > 0 && (ramdom.po == 0 || ramdom.po > time))
        {
            st = 1;

        }
        /*
        if(dt == 1)
        {
            In--;
            dt = 0;
        }*/
	}
}
