using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lever_coin_set : MonoBehaviour {

	 public Transform Basecoin;

    //private Vector3 setpos;

	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {

        //setpos = lever_move_script2.pos;

        if (Input.GetKeyDown(KeyCode.N) && RemoveCoin.havecoin >= 0)
        {

            RemoveCoin.havecoin--;

            Vector3 offset = new Vector3(0, 0, 1);



            Instantiate(Basecoin, transform.position + offset, transform.rotation);
            //生成するオブジェクト（コピー）,このオブジェクトの座標、回転を反映

        }

    }
}
