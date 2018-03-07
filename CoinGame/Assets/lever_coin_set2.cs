using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lever_coin_set2 : MonoBehaviour
{

    public Transform Basecoin;

    //private Vector3 setpos;

    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        //setpos = lever_move_script2.pos;

        if (Input.GetKeyDown(KeyCode.B) && RemoveCoin.havecoin >= 0)
        {

            //Vector3 offset = new Vector3(-1, 2, 0);
            RemoveCoin.havecoin--;

            //Instantiate(Basecoin, setpos+offset, transform.rotation);
            Instantiate(Basecoin, transform.position, transform.rotation);
            //生成するオブジェクト（コピー）,このオブジェクトの座標、回転を反映

        }

    }
}

