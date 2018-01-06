using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lever_move_script : MonoBehaviour {

    private Vector3 origin;
    private Transform originr;
    float angle;

    // Use this for initialization
    void Start () {

        origin = new Vector3(25, 0, 0);
        

    }
	
	// Update is called once per frame
	void Update () {


        if (Input.GetKey(KeyCode.V))
        {
            origin += new Vector3(0, 1, 0);
            //transform.rotation = Quaternion.Euler(origin);
        }

        if (Input.GetKey(KeyCode.B))
        {
            origin += new Vector3(0, -1, 0);
            //transform.rotation = Quaternion.Euler(-1, 0, 0);
        }


        transform.rotation = Quaternion.Euler(origin);

    }


}
