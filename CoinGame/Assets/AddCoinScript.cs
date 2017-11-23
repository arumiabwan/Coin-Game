using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCoinScript : MonoBehaviour {

    public Transform Basecoin;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.Z) || Input.GetKeyDown(KeyCode.X)) {

            Vector3 offset = new Vector3(0, 0, 1);

            Instantiate(Basecoin, transform.position + offset, transform.rotation);
            //生成するオブジェクト（コピー）,このオブジェクトの座標、回転を反映

        }

	}
}
